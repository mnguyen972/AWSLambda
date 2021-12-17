using Newtonsoft.Json;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Supported
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

}