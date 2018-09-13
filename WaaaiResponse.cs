using Newtonsoft.Json;

namespace Waa.ai
{
    public class WaaaiResponse
    {
        [JsonProperty("data")]
        public WaaaiData Data;

        [JsonProperty("success")]
        public bool Success;

        [JsonProperty("status")]
        public int Status;
    }
}