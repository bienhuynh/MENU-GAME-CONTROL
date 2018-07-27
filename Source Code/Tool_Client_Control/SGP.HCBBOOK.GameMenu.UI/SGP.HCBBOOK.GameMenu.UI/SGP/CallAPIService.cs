using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public class CallAPIService : ICallAPIService
    {
        private HttpClient client;
        public CallAPIService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ServerInfo.IPAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IList<GameItem>> GET(string url)
        {
            // HTTP GET
            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    List<GameItem> gameList = await response.Content.ReadAsAsync<List<GameItem>>();
                    return gameList;
                }
            }
                
            return null;
        }

        public async Task<IList<GameItem>> POST(string url)
        {
            using (client)
            {
                // HTTP POST
                List<GameItem> gameItems = new List<GameItem>();
                HttpResponseMessage response = await client.PostAsJsonAsync(url, gameItems);                
                //response = await client.PostAsJsonAsync(url, gameItems);
                if (response.IsSuccessStatusCode)
                {
                    return gameItems;
                }
            }
            return null;
        }

        public async Task POST(string url, GameItem gameItem)
        {
            //using (client)
            //{
            //    using (var wb = new WebClient())
            //    {
            //        var data = new NameValueCollection();
            //        data["username"] = "myUser";
            //        data["password"] = "myPassword";

            //        var response = wb.UploadValues((url), "POST",data);
            //        string responseInString = Encoding.UTF8.GetString(response);
            //    }
            //}
        }

        public string POST(string url, string data)
        {
            string responseInString = null;
            using (client)
            {
                using (var wb = new WebClient())
                {
                    //wb.BaseAddress = "http://localhost:63284";
                    wb.BaseAddress = ServerInfo.IPAddress;
                    var parm = new NameValueCollection();
                    parm["data"] = data;

                    var response = wb.UploadValues((url), "POST", parm);
                    responseInString = Encoding.UTF8.GetString(response);
                }
            }
            return (responseInString);
        }

        public Task<string> POSTAync(string url, string data)
        {
            string responseInString = null;
            using (client)
            {
                using (var wb = new WebClient())
                {
                    //wb.BaseAddress= "http://localhost:63284/";
                    wb.BaseAddress = ServerInfo.IPAddress;
                    var parm = new NameValueCollection();
                    parm["data"] = data;

                    var response = wb.UploadValues((url), "POST", parm);
                    responseInString = Encoding.UTF8.GetString(response);
                }
            }
            return Task.FromResult(responseInString);
        }
    }
}

