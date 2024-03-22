using Newtonsoft.Json;
using System.Text;

namespace BankConfirmation_REST.REST
{
    public class ServiceRest<T>
    {
        private static string GetPath()
        {
            string path = "appsettings.json";

            using (FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bt = new byte[1024];
                UTF8Encoding end = new(true);

                while (fileStream.Read(bt, 0, bt.Length) > 0)
                {
                    return end.GetString(bt);
                }
            }
            return null;
        }

        public List<T> GetList(string url)
        {
            dynamic json = JsonConvert.DeserializeObject(GetPath());
            string BaseAddress = (string)(json["HostApi"]);

            using (HttpClient httpClient = new())
            {
                HttpResponseMessage response = httpClient.GetAsync(BaseAddress + url).Result;
                string data = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<T>>(data);
            }
        }
        public T GetT(int id, string url)
        {
            dynamic json = JsonConvert.DeserializeObject(GetPath());
            string BaseAddress = (string)(json["HostApi"]);

            using (HttpClient httpClient = new())
            {
                HttpResponseMessage response = httpClient.GetAsync(BaseAddress + url + "/" + id.ToString()).Result;
                string data = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T>(data);
            }

        }

        public T SearchT(string search, string url)
        {
            dynamic json = JsonConvert.DeserializeObject(GetPath());
            string BaseAddress = (string)(json["HostApi"]);

            using (HttpClient httpClient = new())
            {
                HttpResponseMessage response = httpClient.GetAsync(BaseAddress + url + "/" + search.ToString()).Result;
                string data = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T>(data);
            }

        }

        public void PutT(T obj, string url)
        {
            dynamic json = JsonConvert.DeserializeObject(GetPath());
            string BaseAddress = (string)(json["HostApi"]);

            using (HttpClient httpClient = new())
            {
                HttpResponseMessage response = httpClient.PutAsJsonAsync(BaseAddress + url, obj).Result;
            }
        }
        public void PostT(T obj, string url)
        {
            dynamic json = JsonConvert.DeserializeObject(GetPath());
            string BaseAddress = (string)(json["HostApi"]);

            using (HttpClient httpClient = new())
            {
                HttpResponseMessage response = httpClient.PostAsJsonAsync(BaseAddress + url, obj).Result;
            }
        }
        public void DeleteT(int id, string url)
        {
            dynamic json = JsonConvert.DeserializeObject(GetPath());
            string BaseAddress = (string)(json["HostApi"]);

            using (HttpClient httpClient = new())
            {
                HttpResponseMessage response = httpClient.DeleteAsync(BaseAddress + url + "/" + id.ToString()).Result;
            }
        }
    }
}
