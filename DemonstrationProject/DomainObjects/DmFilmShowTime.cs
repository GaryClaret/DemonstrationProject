using DemonstrationProject.DomainObjects.DmFilmShowTimeTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemonstrationProject.DomainObjects
{
    public class DmFilmShowTime
    {
        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("releaseYear")]
        public string releaseYear { get; set; }

        [JsonProperty("longDescription")]
        public string longDescription { get; set; }

        [JsonProperty("topCast")]
        public string[] topCast { get; set; }

        [JsonProperty("directors")]
        public string[] directors { get; set; }

        [JsonProperty("runTime")]
        public string runTime { get; set; }

        [JsonProperty("showtimes")]
        public ShowTimes[] showtimes { get; set; }
    }
}