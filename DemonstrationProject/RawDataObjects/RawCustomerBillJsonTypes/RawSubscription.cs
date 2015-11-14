using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes
{
    public class RawSubscription
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public double Cost { get; set; }
    }

}
