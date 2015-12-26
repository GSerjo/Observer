using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwitterInfrastructure.Contracts.Models
{
    public sealed class Entities
    {
        [JsonProperty("hashtags")]
        public List<object> Hashtags { get; set; }

        [JsonProperty("trends")]
        public List<object> Trends { get; set; }

        [JsonProperty("urls")]
        public List<object> Urls { get; set; }

        [JsonProperty("user_mentions")]
        public List<object> UserMentions { get; set; }

        [JsonProperty("symbols")]
        public List<object> Symbols { get; set; }
    }
}