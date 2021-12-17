using Newtonsoft.Json;
using System;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Property
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
        [JsonProperty("timeOfSample")]
        public DateTime TimeOfSample { get; set; }
        [JsonProperty("uncertaintyInMilliseconds")]
        public int UncertaintyInMilliseconds { get; set; }
    }

}