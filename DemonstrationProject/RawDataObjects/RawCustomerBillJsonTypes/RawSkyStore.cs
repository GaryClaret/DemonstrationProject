using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes
{
    public class RawSkyStore
    {
        public RawRental[] Rentals { get; set; }

        public RawBuyAndKeep[] BuyAndKeep { get; set; }

        public double Total { get; set; }
    }

}
