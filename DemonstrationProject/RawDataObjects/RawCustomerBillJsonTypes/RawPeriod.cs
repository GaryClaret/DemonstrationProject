using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;

namespace DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes
{
    public class RawPeriod
    {
        public string From { get; set; }

        public string To { get; set; }
    }
}
