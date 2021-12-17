using Newtonsoft.Json;
using System.Collections.Generic;

namespace AWSLambda.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Endpoint
    {
        [JsonProperty("capabilities")]
        public IList<Capability> Capabilities { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("displayCategories")]
        public IList<string> DisplayCategories { get; set; }
        [JsonProperty("endpointId")]
        public string EndpointId { get; set; }
        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }
        [JsonProperty("manufacturerName")]
        public string ManufacturerName { get; set; }
    }

}