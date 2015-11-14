using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;

namespace DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes
{
    public class RawCallCharges
    {
        public RawCall[] Calls { get; set; }

        public double Total { get; set; }
    }

}
