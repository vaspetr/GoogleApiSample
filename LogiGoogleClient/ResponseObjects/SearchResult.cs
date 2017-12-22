using System.Collections.Generic;

namespace LogiGoogleClient.ResponseObjects
{
    public class SearchResult
    {
        public string Status { get; set; }
        public IEnumerable<Prediction> Predictions { get; set; }    
    }
}