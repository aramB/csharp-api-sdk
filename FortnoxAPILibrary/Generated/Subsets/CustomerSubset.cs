
// ReSharper disable UnusedMember.Global

using Newtonsoft.Json;

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>
    public class CustomerSubset
    {
        /// <remarks/>
        [JsonProperty]
        public string Address1 { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Address2 { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string City { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string CustomerNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Email { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Name { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string OrganisationNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Phone { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string ZipCode { get; set; }

        /// <remarks/>
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }
}
