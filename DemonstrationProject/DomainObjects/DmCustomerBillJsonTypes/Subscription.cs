﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;

namespace DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes
{

    internal class Subscription
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }
    }

}
