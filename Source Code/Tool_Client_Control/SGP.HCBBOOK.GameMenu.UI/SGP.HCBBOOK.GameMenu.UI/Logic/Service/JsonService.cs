using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public class JsonService : IJsonService
    {
        public async Task SaveFileAync(string Path, string fileName, string data)
        {
            //System.IO.IsolatedStorage.IsolatedStorageFile local =
            //    IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null);

            if (!Directory.Exists(String.Format("{0}\\SGP\\Data", Path)))
                Directory.CreateDirectory(String.Format("{0}\\SGP\\Data", Path));

            //using (var isoFileStream =
            //        new System.IO.IsolatedStorage.IsolatedStorageFileStream(
            //            String.Format("C:\\SGP\\Data\\{0}.sgp", fileName),
            //            System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite,
            //                local))
            //{
            //    using (var isoFileWriter = new System.IO.StreamWriter(isoFileStream))
            //    {
            //        isoFileWriter.Write(data);
            //    }
            //}

            using (var isoFileWriter = new System.IO.StreamWriter(String.Format("{0}\\SGP\\Data\\{1}.sgp", Path, fileName))) 
            {
                await isoFileWriter.WriteAsync(data);
            }
        }

        public Task<string> ReadFileAync(string Path, string fileName)
        {
            string data = System.IO.File.ReadAllText(String.Format("{0}\\SGP\\Data\\{1}.sgp",Path, fileName));
            return Task.FromResult(data);
        }

        public async Task SaveFileAync(string Path, string fileName, IList<GameItem> data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = js.Serialize(data);
            await SaveFileAync(Path, fileName, json);
        }

        public void SaveFile(string Path, string fileName, string data)
        {
            //System.IO.IsolatedStorage.IsolatedStorageFile local =
            //    IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null);

            if (!Directory.Exists(String.Format("{0}\\SGP\\Data",Path)))
                Directory.CreateDirectory(String.Format("{0}\\SGP\\Data",Path));

            //using (var isoFileStream =
            //        new System.IO.IsolatedStorage.IsolatedStorageFileStream(
            //            String.Format("C:\\SGP\\Data\\{0}.sgp", fileName),
            //            System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite,
            //                local))
            //{
            //    using (var isoFileWriter = new System.IO.StreamWriter(isoFileStream))
            //    {
            //        isoFileWriter.Write(data);
            //    }
            //}

            using (var isoFileWriter = new System.IO.StreamWriter(String.Format("{0}\\SGP\\Data\\{1}.sgp", Path, fileName)))
            {
                isoFileWriter.Write(data);
            }
        }

        public void SaveFile(string Path, string fileName, IList<GameItem> data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = js.Serialize(data);
            SaveFile(Path, fileName, json);
        }

        public string ReadFile(string Path, string fileName)
        {
            try
            {
                string data = System.IO.File.ReadAllText(String.Format("{0}\\SGP\\Data\\{1}.sgp", Path, fileName));
                return data;
            }
            catch(Exception ex)
            {

            }
            return "";
        }
    }
}
