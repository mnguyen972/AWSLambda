using Newtonsoft.Json;
using System.Collections.Generic;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Payload
    {
        [JsonProperty("endpoints")]
        public IList<Endpoint> Endpoints { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }

}