using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lervik
{
    public static class JsonClient
    {
        public static async Task<T> GetAsync<T>(string url, HttpClientHandler httpClientHandler = null)
        {
            if (httpClientHandler == null)
                httpClientHandler = new HttpClientHandler();

            if (httpClientHandler.SupportsAutomaticDecompression)
                httpClientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate; 

            using (var client = new HttpClient(httpClientHandler))
            using (var stream = await client.GetStreamAsync(url).ConfigureAwait(false))
            using (var sr = new StreamReader(stream))
            using (var reader = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<T>(reader);
            }
        }
    }
}
