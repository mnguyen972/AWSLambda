using Newtonsoft.Json;
using System.Collections.Generic;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Properties
    {
        [JsonProperty("supported")]
        public IList<Supported> Supported { get; set; }
        [JsonProperty("proactivelyReported")]
        public bool ProactivelyReported { get; set; }
        [JsonProperty("retrievable")]
        public bool Retrievable { get; set; }
    }

}