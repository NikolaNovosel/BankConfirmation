using BankConfirmation_UI_MVC.REST;
using Newtonsoft.Json;
using System.Text;

namespace BankConfirmation_REST.REST
{
    public class ServiceRest<T> : Rest
    {
        public List<T> GetList(string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.GetAsync(BaseAddress + url).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<T>>(data);
        }
        public T GetT(int id, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.GetAsync(BaseAddress + url + "/" + id.ToString()).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(data);
        }
        public T SearchT(string search, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.GetAsync(BaseAddress + url + "/" + search.ToString()).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(data);
        }
        public void PutT(T obj, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.PutAsJsonAsync(BaseAddress + url, obj).Result;
        }
        public void PostT(T obj, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.PostAsJsonAsync(BaseAddress + url, obj).Result;
        }
        public void DeleteT(int id, string url)
        {
            using HttpClient httpClient = new();
            HttpResponseMessage response = httpClient.DeleteAsync(BaseAddress + url + "/" + id.ToString()).Result;
        }
    }
}
