using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ContractorPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("idCode")]
        public string? IdCode { get; set; }

        [JsonProperty("idType")]
        public string? IdType { get; set; }

        [JsonProperty("contactName")]
        public string? ContactName { get; set; }

        [JsonProperty("contactTitle")]
        public string? ContactTitle { get; set; }

        [JsonProperty("contactPhone")]
        public string? ContactPhone { get; set; }

        [JsonProperty("contactEmail")]
        public string? ContactEmail { get; set; }
    }
}
