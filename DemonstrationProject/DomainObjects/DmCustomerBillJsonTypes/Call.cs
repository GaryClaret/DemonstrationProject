using Newtonsoft.Json;

namespace DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes
{
    public class Call
    {
        [JsonProperty("called")]
        public string Called { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

    }

}
