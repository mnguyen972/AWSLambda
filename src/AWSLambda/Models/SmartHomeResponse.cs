using Newtonsoft.Json;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class SmartHomeResponse
    {
        [JsonProperty("context")]
        public Context Context { get; set; }

        [JsonProperty("event")]
        public Event Event { get; set; }
    }

}
