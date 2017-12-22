using Newtonsoft.Json;

namespace LogiGoogleClient.ResponseObjects
{
    public class PlaceResult
    {
        [JsonProperty("result")]
        public Address Address { get; set; }
        public string Status { get; set; }
    }
}