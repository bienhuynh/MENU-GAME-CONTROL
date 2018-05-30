package facerecognize.com.facerecognize;

import android.app.Dialog;
import android.app.ProgressDialog;
import android.content.ComponentName;
import android.content.Context;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.net.Uri;
import android.os.Bundle;
import android.os.Debug;
import android.os.StrictMode;
import android.support.annotation.NonNull;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.util.Base64;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.SurfaceView;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;

import android.app.Dialog;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.SurfaceView;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;
import org.opencv.android.BaseLoaderCallback;
import org.opencv.android.CameraBridgeViewBase;
import org.opencv.android.JavaCameraView;
import org.opencv.android.LoaderCallbackInterface;
import org.opencv.android.OpenCVLoader;
import org.opencv.android.Utils;
import org.opencv.core.Core;
import org.opencv.core.CvType;
import org.opencv.core.Mat;
import org.opencv.core.MatOfPoint;
import org.opencv.core.MatOfRect;
import org.opencv.core.Point;
import org.opencv.core.Rect;
import org.opencv.core.Scalar;
import org.opencv.core.Size;
import org.opencv.core.TermCriteria;
import org.opencv.imgproc.Imgproc;
import org.opencv.objdetect.CascadeClassifier;
import org.xmlpull.v1.XmlPullParserException;
//import org.opencv.ml.CvSVM;
//import org.opencv.ml.CvSVMParams;

import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.Socket;
import java.security.Policy;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class MainActivity extends AppCompatActivity implements CameraBridgeViewBase.CvCameraViewListener2 {

    private static String TAG = "MainActivity";
    private Context mContext;
    private int screenWidth;
    private int screenHeight;
    private int imgWidth = 320;
    private int imgHeight = 240;
    private float ratioWidth;
    private float ratioHeight;
    private ImageView imgView;
    JavaCameraView javaCameraView;
    private RelativeLayout parentView;
    private TextView tvStatus;
    private View faceArea;
    int i = 0;
    Dialog mDialog;
    Mat mRgba;
    private Timer detectFaceTimer;
    private ProgressDialog progressDialog;
    private ImageView imgFace;
    /**
     * Load camera opencv
     */
    BaseLoaderCallback mLoaderCallback = new BaseLoaderCallback(this) {
        @Override
        public void onManagerConnected(int status) {
            switch (status) {
                case BaseLoaderCallback.SUCCESS: {
                    javaCameraView.enableView();
                    initializeOpenCVDependencies();
                    break;
                }
                default: {
                    super.onManagerConnected(status);
                }


            }
        }
    };
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
        getWindow().addFlags(WindowManager.LayoutParams.FLAG_KEEP_SCREEN_ON);
        setContentView(R.layout.activity_main);

        //Lấy độ phân giải mà hình nằm ngang
        DisplayMetrics displayMetrics = new DisplayMetrics();
        getWindowManager().getDefaultDisplay().getMetrics(displayMetrics);
        screenHeight = displayMetrics.heightPixels;
        screenWidth = displayMetrics.widthPixels;
        if(screenHeight>screenWidth){
            int tmp = screenHeight;
            screenHeight = screenWidth;
            screenWidth = tmp;
        }

        //set các thuộc tính camera
        javaCameraView = (JavaCameraView) findViewById(R.id.java_camera_view);
        javaCameraView.setVisibility(SurfaceView.VISIBLE);
        javaCameraView.setCvCameraViewListener(this);
        javaCameraView.setMaxFrameSize(screenWidth, screenHeight);

        //Tính tỉ lệ của ảnh khi thu nhỏ so với ảnh gốc
        ratioWidth = (float)screenWidth/(float) imgWidth;
        ratioHeight = (float)screenHeight/(float) imgHeight;
        parentView = (RelativeLayout) findViewById(R.id.parentView);
        faceArea = (View)findViewById(R.id.faceArea);
        Log.w("Screen width:", ""+ratioWidth);
        Log.w("Screen height:", ""+ratioHeight);
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();

        StrictMode.setThreadPolicy(policy);
        mContext = this;
        tvStatus = (TextView)findViewById(R.id.tvStatus);
        progressDialog = new ProgressDialog(mContext);
        imgFace = (ImageView) findViewById(R.id.faceDetected);
    }

    @Override
    protected void onPause() {
        super.onPause();
        detectFaceTimer.cancel();
        if (javaCameraView != null)
            javaCameraView.disableView();
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        if (javaCameraView != null)
            javaCameraView.disableView();
    }

    @Override
    protected void onResume() {
        super.onResume();
        if (OpenCVLoader.initDebug()) {
            Log.i(TAG, "Load Thành Công");
            mLoaderCallback.onManagerConnected(LoaderCallbackInterface.SUCCESS);
        } else {
            Log.i(TAG, "Load không thành công");
            OpenCVLoader.initAsync(OpenCVLoader.OPENCV_VERSION_2_4_10, this, mLoaderCallback);
        }

        //Timer để phát hiện khuôn mặt
        detectFaceTimer = new Timer();
        detectFaceTimer.schedule(new TimerTask() {
            @Override
            public void run() {
                if(mRgba!=null){
                    try{
                    detectface(mRgba);}
                    catch (Exception e){

                    }
                }
            }
        }, 0, 700);
    }

    @Override
    public void onCameraViewStarted(int width, int height) {
        mRgba = new Mat(width, height, CvType.CV_16S);

    }

    @Override
    public void onCameraViewStopped() {
        mRgba.release();

    }
    boolean set = false;
    Bitmap bm;
    @Override
    public Mat onCameraFrame(CameraBridgeViewBase.CvCameraViewFrame inputFrame) {
        Mat nA;
        mRgba = inputFrame.rgba();
//        Point center = new Point(nA.cols()/2, nA.rows()/2);
//        Mat mat_rot = Imgproc.getRotationMatrix2D(center,0,1.0);
//        Imgproc.warpAffine(nA,mRgba,mat_rot,nA.size());

        return mRgba;
    }
    private CascadeClassifier faceCascadeClassifier, eyeCascadeClassifier;
    private Mat grayScaleImage;
    private int absoluteFaceSize;

    /**
     * Load file xml để phát hiện khuôn mặt
     */
    private void initializeOpenCVDependencies() {
        try {
            // Load the face cascade classifier
            // Copy the resource into a temp file so OpenCV can load it
            // copy the xml data to the program
            InputStream is = getResources().openRawResource(R.raw.haarcascade_frontalface_default);
            File cascadeDir = getDir("cascade", Context.MODE_PRIVATE);
            File mCascadeFile = new File(cascadeDir, "haarcascade_frontalface_default.xml");
            FileOutputStream os = new FileOutputStream(mCascadeFile);


            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = is.read(buffer)) != -1) {
                os.write(buffer, 0, bytesRead);
            }
            is.close();
            os.close();


            // Load the eye cascade classifier

            faceCascadeClassifier = new CascadeClassifier(mCascadeFile.getAbsolutePath());

        } catch (Exception e) {
            Log.e("OpenCVActivity", "Error loading cascade", e);
        }
        // And we are ready to go
        // openCvCameraView.enableView();
    }


    static {
        if(OpenCVLoader.initDebug())
        {
            Log.d("TAG" , "Opencv not loaded");
        }
        else
        {
            Log.d("TAG" , "Opencv Loaded");
        }
    }
    private List<View> faceAreaView = new ArrayList<>();

    /**
     * Phát hiện khuôn mặt có trong hình
     * @param inputFrame
     */
    public synchronized void detectface(Mat inputFrame) {
        Date startTime = new Date();
        grayScaleImage = new Mat();
        // Create a gray scale image
        Imgproc.cvtColor(inputFrame, grayScaleImage, Imgproc.COLOR_RGBA2GRAY);
        Imgproc.resize(grayScaleImage, grayScaleImage, new Size(320, 240));
        MatOfRect faces = new MatOfRect();

        // Use the classifier to detect faces
        if (faceCascadeClassifier != null) {
            faceCascadeClassifier.detectMultiScale(grayScaleImage, faces, 1.2, 10, 2,
                    new Size(20, 20), new Size());
            //Log.d("Detected %s face(s)", Integer.toString(faces.toArray().length));
        }


        final Rect[] facesArray = faces.toArray();
        if(facesArray.length==0){
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    imgFace.setImageBitmap(null);
                    faceArea.setVisibility(View.INVISIBLE);
                }
            });
        }
        faceAreaView = new ArrayList<>();
        for (int i = 0; i < facesArray.length; i++) {
            int width = (int)(facesArray[i].width*ratioWidth);
            int height = (int)(facesArray[i].height*ratioHeight);
            final RelativeLayout.LayoutParams layoutParams=new RelativeLayout.LayoutParams(width,height );
            int x = (int)(facesArray[i].x*ratioWidth);
            int y = (int)(facesArray[i].y*ratioWidth);
            layoutParams.setMargins(x, y, screenWidth-(x+width)-100, screenHeight-(y+height)-100);
            final int finalI = i;
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    faceArea.setLayoutParams(layoutParams);
                    faceArea.setVisibility(View.VISIBLE);
                    Mat face = new Mat(grayScaleImage, facesArray[finalI]);
                    Bitmap tmp =  Bitmap.createBitmap(facesArray[finalI].width, facesArray[finalI].height, Bitmap.Config.ARGB_8888);
                    Utils.matToBitmap(face, tmp);
                    imgFace.setImageBitmap(tmp);
                }
            });
        }
        Date endTime = new Date();
        long total = endTime.getTime() - startTime.getTime();
        //Log.w("Time", ""+total);
    }
    private String image2Base64(Bitmap bitmap) {
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        bitmap.compress(Bitmap.CompressFormat.PNG, 100, byteArrayOutputStream);
        byte[] byteArray = byteArrayOutputStream.toByteArray();
        String encoded = Base64.encodeToString(byteArray, Base64.DEFAULT);
        return encoded;
    }

    /**
     * Train data
     */
    private String trainName;
    public void btnCaptureClick(View view) {

        //Convert Mat sang chuỗi base64
        ByteArrayOutputStream stream = new ByteArrayOutputStream();
        Bitmap bmp = Bitmap.createBitmap(mRgba.width(), mRgba.height(), Bitmap.Config.ARGB_8888);
        Utils.matToBitmap(mRgba, bmp);
        final String imgData = image2Base64(bmp);

        //Hiện popup
        final Dialog alert = new Dialog(this, R.style.CustomDialog);
        alert.requestWindowFeature(Window.FEATURE_NO_TITLE);
        LayoutInflater inflater = (LayoutInflater) mContext.getSystemService(LAYOUT_INFLATER_SERVICE);
        View vi = inflater.inflate(R.layout.dialog, null);
        final EditText edtName = (EditText) vi.findViewById(R.id.edtName);
        final Button btnOK = (Button) vi.findViewById(R.id.btnOK);

        //Sự kiện khi bấm ok trong popup
        btnOK.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(edtName.getText().toString().equals("")){
                    Toast.makeText(mContext, "Bạn phải nhập tên nhân viên!", Toast.LENGTH_SHORT).show();
                    return;
                }

                progressDialog.setTitle("Vui lòng đợi!");
                progressDialog.setMessage("Đang train dữ liệu!");
                progressDialog.show();
                alert.cancel();
                Thread th = new Thread(){
                    public  void run(){

                        try {
                            trainImage(edtName.getText().toString(), imgData);
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                    }
                };
                th.start();
            }
        });

        Button btnCancel = (Button) vi.findViewById(R.id.btnCancel);

        //Sự kiện khi bấm cancel
        btnCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                alert.cancel();
            }
        });

        alert.setContentView(vi);
        DisplayMetrics displaymetrics = new DisplayMetrics();
        getWindowManager().getDefaultDisplay().getMetrics(displaymetrics);
        alert.getWindow().setLayout(screenWidth/2, screenHeight/2);
        alert.show();

    }

    /**
     * Nhận diện khuôn mặt
     * @param view
     */
    public void btnRecognizeClick(View view) {

        progressDialog.setTitle("Vui lòng đợi!");
        progressDialog.setMessage("Đang nhận dạng!");
        progressDialog.show();
        tvStatus.setText("");
        ByteArrayOutputStream stream = new ByteArrayOutputStream();
        Bitmap bmp = Bitmap.createBitmap(mRgba.width(), mRgba.height(), Bitmap.Config.ARGB_8888);
        Utils.matToBitmap(mRgba, bmp);
        final String imgData = image2Base64(bmp);
        Thread th = new Thread(){
            public  void run(){

                try {
                    recognizeImage(imgData);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        };
        th.start();
    }

    //Thông tin webservice
    private String host = "http://192.168.167.2:3232/";
    private  final int SERVICE_TIME_OUT = 300000;
    private  final String NAMESPACE = "http://tempuri.org/";
    private  final String URL =
            host+"TrainImage.asmx?wsdl";
    private  String SOAP_ACTION = "http://tempuri.org/Train";
    private  String METHOD_NAME = "Train";

    /**
     * Train image
     * @param name :Tên nhân viên
     * @param data : Dữ liệu ảnh dưới dạng chuỗi base64
     * @throws Exception: xuất lỗi khi phát hiện
     */
    public void trainImage(String name, String data) throws Exception {

         String SOAP_ACTION = "http://tempuri.org/Train";
         String METHOD_NAME = "Train";
        SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME);

        //Các parameter để gọi web service
        PropertyInfo nameProp = new PropertyInfo();
        nameProp.setName("name");
        nameProp.setValue(name);
        nameProp.setType(String.class);
        request.addProperty(nameProp);

        PropertyInfo fileDataProp = new PropertyInfo();
        fileDataProp.setName("fileData");
        fileDataProp.setValue(data);
        fileDataProp.setType(String.class);
        request.addProperty(fileDataProp);


        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        envelope.setOutputSoapObject(request);
        envelope.dotNet = true;
        HttpTransportSE androidHttpTransport = new HttpTransportSE(URL, SERVICE_TIME_OUT);
        try {
            androidHttpTransport.call(SOAP_ACTION, envelope);

            SoapPrimitive response = (SoapPrimitive) envelope.getResponse();
            final String result = response.toString();

            //Hiện kết quả từ server
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    tvStatus.setText(result);
                }
            });
        } catch (IOException e) {
            e.printStackTrace();
            throw e;

        } catch (XmlPullParserException e) {
            e.printStackTrace();
            throw e;
        }
        finally {
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    progressDialog.dismiss();
                }
            });
        }
    }

    /**
     * Giống train image
     * @param data: dữ liệu ảnh dưới dạng chuỗi base64
     * @throws Exception
     */
    public void recognizeImage(String data) throws Exception {

        String SOAP_ACTION = "http://tempuri.org/Recognize";
        String METHOD_NAME = "Recognize";
        SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME);


        PropertyInfo fileDataProp = new PropertyInfo();
        fileDataProp.setName("fileData");
        fileDataProp.setValue(data);
        fileDataProp.setType(String.class);
        request.addProperty(fileDataProp);


        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        envelope.setOutputSoapObject(request);
        envelope.dotNet = true;
        HttpTransportSE androidHttpTransport = new HttpTransportSE(URL, SERVICE_TIME_OUT);

        try {

            androidHttpTransport.call(SOAP_ACTION, envelope);
            SoapPrimitive response = (SoapPrimitive) envelope.getResponse();
            final String result = response.toString();
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    tvStatus.setText(result);
                }
            });
        } catch (IOException e) {
            e.printStackTrace();
            throw e;

        } catch (XmlPullParserException e) {
            e.printStackTrace();
            throw e;
        }
        finally {
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    progressDialog.dismiss();
                }
            });
        }
    }

    /**
     * Xem lịch sử
     * @param view
     */
    public void btnListClick(View view) {
        Intent intent = new Intent(mContext, ListActivity.class);
        startActivity(intent);
    }
}

