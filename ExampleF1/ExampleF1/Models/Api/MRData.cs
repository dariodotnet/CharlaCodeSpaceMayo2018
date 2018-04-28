using Newtonsoft.Json;
using System.Collections.Generic;

namespace ExampleF1.Models
{
    public class Driver
    {
        [JsonProperty(PropertyName = "driverId")]
        public string DriverId { get; set; }

        [JsonProperty(PropertyName = "permantentNumber")]
        public string PermanentNumber { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        [JsonProperty(PropertyName = "familyName")]
        public string FamilyName { get; set; }

        [JsonProperty(PropertyName = "dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }
    }

    public class DriverTable
    {
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        public List<Driver> Drivers { get; set; }
    }

    public class MRData
    {
        [JsonProperty(PropertyName = "xmlns")]
        public string Xmlns { get; set; }

        [JsonProperty(PropertyName = "series")]
        public string Series { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; set; }

        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        public DriverTable DriverTable { get; set; }
    }

    public class ApiResponse
    {
        public MRData MRData { get; set; }
    }
}