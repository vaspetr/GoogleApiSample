using System.Collections.Generic;
using Newtonsoft.Json;

namespace LogiGoogleClient.ResponseObjects
{
    public class AddressComponent
    {
        public IEnumerable<string> Types { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("long_name")]
        public string LongName { get; set; }
    }
}