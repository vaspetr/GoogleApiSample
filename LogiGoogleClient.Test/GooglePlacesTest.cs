using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogiGoogleClient.Test
{
    [TestClass]
    public class GooglePlacesTest
    {
        private GoogleApiConfiguration _configuration;
        private PlacesApiClient _googleClient;

        [TestInitialize]
        public void Init()
        {
            _configuration = new GoogleApiConfiguration
            {
                ApiKey = "AIzaSyDR-7fLyQ2vo7RDPHx_8L7lDX-GeY5t7xM",
                PlacesApiUrl = "https://maps.googleapis.com/maps/api/place"
            };
            _googleClient = new PlacesApiClient(_configuration);
        }

        [TestMethod]
        //ignored to avoid excessive requests
        public void Search()
        {
            const string search = "Westminster Abbey";

            var result = _googleClient.SearchText(search);

            Assert.AreEqual(result.Status, "OK");
        }

        [TestMethod]
        //ignored to avoid excessive requests
        public void GetPlace()
        {
            const string id = "ChIJRUeRWcMEdkgRAO7ZzLCgDXA";

            var result = _googleClient.GetPlace(id);

            Assert.AreEqual(result.Address.City, "London");
            Assert.AreEqual(result.Address.Country, "United Kingdom");
        }

    }
}
