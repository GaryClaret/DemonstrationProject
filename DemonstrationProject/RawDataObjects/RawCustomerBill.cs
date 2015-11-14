using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes;

namespace DemonstrationProject.RawDataObjects
{
    public class RawCustomerBill
    {
        public RawStatement Statement { get; set; }

        public double Total { get; set; }
      
        public RawPackage Package { get; set; }

        public RawCallCharges CallCharges { get; set; }

        public RawSkyStore SkyStore { get; set; }
    }
}
