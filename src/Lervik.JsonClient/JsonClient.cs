using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lervik
{
    public static class JsonClient
    {
        public static async Task<T> GetAsync<T>(string url, HttpMessageHandler httpMessageHandler = null)
        {
            using (var client = httpMessageHandler != null ? new HttpClient(httpMessageHandler) : new HttpClient())
            using (var stream = await client.GetStreamAsync(url))
            using (var sr = new StreamReader(stream))
            using (var reader = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<T>(reader);
            }
        }
    }
}
