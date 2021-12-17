using Newtonsoft.Json;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Event
    {
        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        [JsonProperty("endpoint")]
        public Endpoint Endpoint { get; set; }
    }

}