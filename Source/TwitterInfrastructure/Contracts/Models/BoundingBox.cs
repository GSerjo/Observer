using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwitterInfrastructure.Contracts.Models
{
    public sealed class BoundingBox
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<List<List<double>>> Coordinates { get; set; }
    }
}