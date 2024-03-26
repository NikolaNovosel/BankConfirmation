using Newtonsoft.Json;

namespace BankConfirmation_UI_MVC.REST
{
    internal class ServiceRest<T> : Rest
    {
        internal List<T> GetList(string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.GetAsync(baseAddress + url).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<T>>(data);
        }
        internal T GetT(int id, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.GetAsync(baseAddress + url + "/" + id.ToString()).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(data);
        }

        internal T SearchT(string search, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.GetAsync(baseAddress + url + "/" + search.ToString()).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(data);   
        }

        internal void PutT(T obj, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.PutAsJsonAsync(baseAddress + url, obj).Result;
        }
        internal void PostT(T obj, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.PostAsJsonAsync(baseAddress + url, obj).Result;
        }
        internal void DeleteT(int id, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.DeleteAsync(baseAddress + url + "/" + id.ToString()).Result;   
        }
    }
}
