using Newtonsoft.Json;
using System.Collections.Generic;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Context
    {
        [JsonProperty("properties")]
        public IList<Property> Properties { get; set; }
    }

}