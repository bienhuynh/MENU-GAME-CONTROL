using System;
using System.Diagnostics;
using Emgu.CV.Structure;

namespace Emgu.CV
{
    [Serializable]
    public class EigenRecognizer
    {
        //Khai báo biến
        private Image<Gray, Single>[] _eigenImages;
        private Image<Gray, Single> _avgImage;
        private Matrix<float>[] _eigenValues;
        private string[] _labels;
        private double _eigenDistanceThreshold;

        /// <summary>
        /// Các hàm get set
        /// </summary>
        public Image<Gray, Single>[] EigenImages
        {
            get { return _eigenImages; }
            set { _eigenImages = value; }
        }
        public String[] Labels
        {
            get { return _labels; }
            set { _labels = value; }
        }
        public double EigenDistanceThreshold
        {
            get { return _eigenDistanceThreshold; }
            set { _eigenDistanceThreshold = value; }
        }
        public Image<Gray, Single> AverageImage
        {
            get { return _avgImage; }
            set { _avgImage = value; }
        }
        public Matrix<float>[] EigenValues
        {
            get { return _eigenValues; }
            set { _eigenValues = value; }
        }

        /// <summary>
        /// Các contrustor
        /// </summary>
        private EigenRecognizer()
        {
        }


        public EigenRecognizer(Image<Gray, Byte>[] images, ref MCvTermCriteria termCrit)
            : this(images, GenerateLabels(images.Length), ref termCrit)
        {
        }

        private static String[] GenerateLabels(int size)
        {
            String[] labels = new string[size];
            for (int i = 0; i < size; i++)
                labels[i] = i.ToString();
            return labels;
        }
        public EigenRecognizer(Image<Gray, Byte>[] images, String[] labels, ref MCvTermCriteria termCrit)
            : this(images, labels, 0, ref termCrit)
        {
        }

        public EigenRecognizer(Image<Gray, Byte>[] images, String[] labels, double eigenDistanceThreshold, ref MCvTermCriteria termCrit)
        {
            Debug.Assert(images.Length == labels.Length, "The number of images should equals the number of labels");
            Debug.Assert(eigenDistanceThreshold >= 0.0, "Eigen-distance threshold should always >= 0.0");

            CalcEigenObjects(images, ref termCrit, out _eigenImages, out _avgImage);

            _eigenValues = Array.ConvertAll<Image<Gray, Byte>, Matrix<float>>(images,
                delegate(Image<Gray, Byte> img)
                {
                    return new Matrix<float>(EigenDecomposite(img, _eigenImages, _avgImage));
                });

            _labels = labels;

            _eigenDistanceThreshold = eigenDistanceThreshold;
        }
        /// <summary>
        /// Tính toán eigen của ảnh đã train
        /// </summary>
        /// <param name="trainingImages">Ảnh cần train </param>
        /// <param name="termCrit">criteria của ảnh train</param>
        /// <param name="eigenImages">Kết quả</param>
        /// <param name="avg"></param>
        public static void CalcEigenObjects(Image<Gray, Byte>[] trainingImages, ref MCvTermCriteria termCrit, out Image<Gray, Single>[] eigenImages, out Image<Gray, Single> avg)
        {
            int width = trainingImages[0].Width;
            int height = trainingImages[0].Height;

            IntPtr[] inObjs = Array.ConvertAll<Image<Gray, Byte>, IntPtr>(trainingImages, delegate(Image<Gray, Byte> img) { return img.Ptr; });

            if (termCrit.max_iter <= 0 || termCrit.max_iter > trainingImages.Length)
                termCrit.max_iter = trainingImages.Length;

            int maxEigenObjs = termCrit.max_iter;

            #region initialize eigen images
            eigenImages = new Image<Gray, float>[maxEigenObjs];
            for (int i = 0; i < eigenImages.Length; i++)
                eigenImages[i] = new Image<Gray, float>(width, height);
            IntPtr[] eigObjs = Array.ConvertAll<Image<Gray, Single>, IntPtr>(eigenImages, delegate(Image<Gray, Single> img) { return img.Ptr; });
            #endregion

            avg = new Image<Gray, Single>(width, height);

            CvInvoke.cvCalcEigenObjects(
                inObjs,
                ref termCrit,
                eigObjs,
                null,
                avg.Ptr);
        }
        public static float[] EigenDecomposite(Image<Gray, Byte> src, Image<Gray, Single>[] eigenImages, Image<Gray, Single> avg)
        {
            return CvInvoke.cvEigenDecomposite(
                src.Ptr,
                Array.ConvertAll<Image<Gray, Single>, IntPtr>(eigenImages, delegate(Image<Gray, Single> img) { return img.Ptr; }),
                avg.Ptr);
        }
        public Image<Gray, Byte> EigenProjection(float[] eigenValue)
        {
            Image<Gray, Byte> res = new Image<Gray, byte>(_avgImage.Width, _avgImage.Height);
            CvInvoke.cvEigenProjection(
                Array.ConvertAll<Image<Gray, Single>, IntPtr>(_eigenImages, delegate(Image<Gray, Single> img) { return img.Ptr; }),
                eigenValue,
                _avgImage.Ptr,
                res.Ptr);
            return res;
        }

        /// <summary>
        /// <paramref name="image"/> Lấy eigen distance của ảnh
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public float[] GetEigenDistances(Image<Gray, Byte> image)
        {
            using (Matrix<float> eigenValue = new Matrix<float>(EigenDecomposite(image, _eigenImages, _avgImage)))
                return Array.ConvertAll<Matrix<float>, float>(_eigenValues,
                    delegate(Matrix<float> eigenValueI)
                    {
                        return (float)CvInvoke.cvNorm(eigenValue.Ptr, eigenValueI.Ptr, Emgu.CV.CvEnum.NORM_TYPE.CV_L2, IntPtr.Zero);
                    });
        }

        /// <summary>
        /// <paramref name="image"/> tìm ảnh tương tự nhất trong các ảnh đã train
        /// </summary>
        /// <param name="image">Ảnh cần tìm</param>
        /// <param name="index">thứ tự của ảnh tìm thấy</param>
        /// <param name="eigenDistance">Eigen distance của ảnh tìm thấy</param>
        /// <param name="label">Tên nhân viên</param>
        public void FindMostSimilarObject(Image<Gray, Byte> image, out int index, out float eigenDistance, out String label)
        {
            float[] dist = GetEigenDistances(image);

            index = -1;
            eigenDistance = dist[0];
            for (int i = 1; i < dist.Length; i++)
            {
                if (dist[i] < eigenDistance)
                {
                    index = i;
                    eigenDistance = dist[i];
                }
            }
            if (index > -1)
            {
                label = Labels[index];
            }
            else
            {
                label = "";
            }
        }

        /// <summary>
        /// Nhận diện ảnh
        /// </summary>
        /// <param name="image">Ảnh của nhân viên</param>
        /// <returns>
        /// trả về rỗng nếu không nhận diện được
        /// Tên nhân viên tương ứng
        /// </returns>
        public String Recognize(Image<Gray, Byte> image)
        {
            int index;
            float eigenDistance;
            String label;
            FindMostSimilarObject(image, out index, out eigenDistance, out label);
            Console.WriteLine(index);
            if ((_eigenDistanceThreshold <= 0 || eigenDistance < _eigenDistanceThreshold) && index > -1)
            {
                return Labels[index];
            }
            else
            {
                return "";
            }
        }
    }
}
