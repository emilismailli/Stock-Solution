using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MHM.Accountancy.Business.Infrastructure.Extensions
{
    class HttpExtension
    {
        #region async helper methods

        // SELECT

        static public async Task<T> Get<T>(string endpoint)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(endpoint);
                string content = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<T>(content));
            }
        }

        // INSERT

        static public async Task<T> Post<T>(string endpoint, object data)
        {
            using (var client = new HttpClient())
            {
                var httpContent = new StringContent(JsonConvert.SerializeObject(data));
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync(endpoint, httpContent);
                string content = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<T>(content));
            }
        }

        // UPDATE

        static public async Task<T> Put<T>(string endpoint, object data)
        {
            using (var client = new HttpClient())
            {
                var httpContent = new StringContent(JsonConvert.SerializeObject(data));
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PutAsync(endpoint, httpContent);
                string content = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<T>(content));
            }
        }

        // DELETE

        static public async Task<T> Delete<T>(string endpoint)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(endpoint);
                string content = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<T>(content));
            }
        }

        #endregion
    }
}
