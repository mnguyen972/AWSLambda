using Newtonsoft.Json;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Capability
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("interface")]
        public string Interface { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

}