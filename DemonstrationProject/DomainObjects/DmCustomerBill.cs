using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;

namespace DemonstrationProject.DomainObjects
{
    public class DmCustomerBill
    {
        [JsonProperty("statement")]
        public Statement Statement { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("package")]
        public Package Package { get; set; }

        [JsonProperty("callCharges")]
        public CallCharges CallCharges { get; set; }

        [JsonProperty("skyStore")]
        public SkyStore SkyStore { get; set; }
    }

}
