using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemonstrationProject.DomainObjects.DmFilmShowTimeTypes
{
    public class ShowTimes
    {
            [JsonProperty("theatre")]
            public Theatre theatre { get; set; }

            [JsonProperty("string")]
            public string dateTime { get; set; }
    }
}