using System;
using System.Net.Http;
using LogiGoogleClient.ResponseObjects;
using Newtonsoft.Json;

namespace LogiGoogleClient
{
    public class PlacesApiClient
    {
        private readonly GoogleApiConfiguration _configuration;
        private readonly HttpClient _client;

        public PlacesApiClient(GoogleApiConfiguration configuration)
        {
            _configuration = configuration;
            _client = new HttpClient();
        }

        public SearchResult SearchText(string input)
        {
            var url = new Uri(_configuration.PlacesApiUrl + "/autocomplete/json" + $"?input={input}&key={_configuration.ApiKey}");

            var result = _client.GetAsync(url).Result;

            return JsonConvert.DeserializeObject<SearchResult>(result.Content.ReadAsStringAsync().Result);
        }

        public PlaceResult GetPlace(string id)
        {
            var url = new Uri(_configuration.PlacesApiUrl + "/details/json" + $"?placeid={id}&key={_configuration.ApiKey}");

            var result = _client.GetAsync(url).Result;

            return JsonConvert.DeserializeObject<PlaceResult>(result.Content.ReadAsStringAsync().Result);
        }
    }
}