using Newtonsoft.Json;

namespace LogiGoogleClient.ResponseObjects
{
    public enum ComponentType
    {
        Floor,
        [JsonProperty("street_number")]
        StreetNumber,
        Route,
        Locality,
        [JsonProperty("administrative_area_level_1")]
        AdministrativeAreaLevel1,
        [JsonProperty("administrative_area_level_2")]
        AdministrativeAreaLevel2,
        Country,
        [JsonProperty("postal_code")]
        PostalCode,
        Political
    }
}