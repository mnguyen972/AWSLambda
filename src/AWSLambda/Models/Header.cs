using Newtonsoft.Json;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Header
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("payloadVersion")]
        public string PayloadVersion { get; set; }
    }

}