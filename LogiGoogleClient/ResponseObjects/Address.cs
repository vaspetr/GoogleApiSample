using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

namespace LogiGoogleClient.ResponseObjects
{
    public class Address
    {
        private readonly string _city = "locality";
        private readonly string _country = "country";
        private readonly string _province = "administrative_area_level_2";
        private readonly string _postalCode = "postal_code";

        private XmlDocument _xmlAddress;

        [JsonProperty("address_components")]
        public IEnumerable<AddressComponent> AddressComponents { get; set; }
        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
        public Location Location { get; set; }
        public ViewPort ViewPort { get; set; }
        [JsonProperty("international_phone_number")]
        public string InternationalPhoneNumber { get; set; }

        [JsonProperty("adr_address")]
        public string HtmlAddress { get; set; }


        public XmlDocument XmlAddress
        {
            get
            {
                if (_xmlAddress != null) return _xmlAddress;
                _xmlAddress = new XmlDocument();
                _xmlAddress.LoadXml($"<div>{HtmlAddress}</div>");
                return _xmlAddress;
            }
        }

        public string City
        {
            get
            {
                var node = XmlAddress.SelectSingleNode("div/span[@class=\'locality\']");
                return node?.InnerText ?? AddressComponents.FirstOrDefault(c => c.Types.Contains(_city))?.LongName;
            }
        }

        public string Country
        {
            get { return AddressComponents.FirstOrDefault(c => c.Types.Contains(_country))?.LongName; }
        }

        public string Province
        {
            get
            {
                var node = XmlAddress.SelectSingleNode("div/span[@class=\'region\']");

                if (node == null) return AddressComponents.FirstOrDefault(c => c.Types.Contains(_province))?.LongName;

                var regionCode = node.InnerText;
                var regionName = AddressComponents.FirstOrDefault(c => c.ShortName == regionCode)?.LongName;
                return regionName ?? regionCode;
            }
        }

        public string PostalCode => AddressComponents.FirstOrDefault(c => c.Types.Contains(_postalCode))?.LongName;
    }
}