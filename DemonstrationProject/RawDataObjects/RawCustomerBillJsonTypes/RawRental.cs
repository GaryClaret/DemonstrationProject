using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;

namespace DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes
{
    public class RawRental
    {
        public string Title { get; set; }

        public double Cost { get; set; }
    }

}
