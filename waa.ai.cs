using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Waa.ai
{
    public class WaaaiClient
    {
        string BaseUrl = "https://api.waa.ai/shorten?url=";
        string APIKey;

        public WaaaiClient(String Key)
        {
            APIKey = Key;
        }

        public async Task<WaaaiResponse> ShortUrl(string Url)
        {
            HttpClient Client = new HttpClient();
            string Data = await Client.GetStringAsync($"{BaseUrl}{Url}&&key={APIKey}");
            return JsonConvert.DeserializeObject<WaaaiResponse>(Data);
        }
    }
}
