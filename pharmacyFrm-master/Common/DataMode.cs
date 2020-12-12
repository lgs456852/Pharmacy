using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyFrm.Common
{
    public class DataMode
    {
        const string openURL = "http://handfarm.kro.kr:50001/api/OpenPF/";

        public DataMode()
        {

        }

        public void Excute(string Q)
        {
            string url = openURL + Q + ";";  //테스트 사이트
            string responseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 30 * 1000; // 30초
            request.Headers.Add("Authorization", "BASIC SGVsbG8="); // 헤더 추가 방법

            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);  // 정상이면 "OK"
                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }
            }
            Console.WriteLine(responseText);
        }
        public async Task<JArray> OpenAsync(string Q)
        {
            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri(string.Format($"{openURL}{Q}", string.Empty));

                var response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string c = await response.Content.ReadAsStringAsync();
                    var item = JsonConvert.DeserializeObject<JObject>(c);
                    JArray returnJarray = new JArray();
                    try
                    {
                        if (item.GetValue("Result").ToString().Equals("SUCC"))
                        {
                            returnJarray = (JArray)item.GetValue("Msg");
                        }
                        else
                        {
                            Debug.WriteLine(item.GetValue("Msg"));
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.ToString());
                    }

                    return returnJarray;
                }
                else
                {
                    Debug.WriteLine(response.StatusCode.ToString());
                    return null;
                }
            }
        }
    }
}
