using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;

namespace DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes
{
    public class RawCall
    {
        public string Called { get; set; }

        public string Duration { get; set; }

        public double Cost { get; set; }
    }

}
