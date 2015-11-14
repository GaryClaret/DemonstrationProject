using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes
{

    public class RawStatement
    {
        public string Generated { get; set; }

        public string Due { get; set; }

        public RawPeriod Period { get; set; }
    }

}
