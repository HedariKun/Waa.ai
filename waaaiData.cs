using Newtonsoft.Json;

namespace Waa.ai
{
    public class WaaaiData
    {
        [JsonProperty("url")]
        public string Url;

        [JsonProperty("short_code")]
        public string ShortUrlCode;

        [JsonProperty("extension")]
        public string Extension;

        [JsonProperty("delete_link")]
        public string DeleteLink;

        [JsonProperty("delete_hash")]
        public string DeleteHash;

        [JsonProperty("long_url")]
        public string LongUrl;
    }
}