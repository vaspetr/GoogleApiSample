using Newtonsoft.Json;

namespace LogiGoogleClient.ResponseObjects
{
    public class Location
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }
}