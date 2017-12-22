using System.Collections.Generic;
using Newtonsoft.Json;

namespace LogiGoogleClient.ResponseObjects
{
    public class Prediction
    {
        public string Description { get; set; }
        public string Id { get; set; }
        [JsonProperty("matched_substrings")]
        public IEnumerable<MatchedSubstring> MatchedSubstrings { get; set; }
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }
        public string Reference { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}