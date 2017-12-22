using System.Collections.Generic;
using Newtonsoft.Json;

namespace LogiGoogleClient.ResponseObjects
{
    public class PredictionDetails
    {
        [JsonProperty("main_text")]
        public string MainText { get; set; }
        [JsonProperty("secondary_text")]
        public string SecondaryText { get; set; }
        [JsonProperty("main_text_matched_substrings")]
        public IEnumerable<MatchedSubstring> MainTextMatchedStrings { get; set; }
    }
}

