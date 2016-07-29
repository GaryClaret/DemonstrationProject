using DemonstrationProject.DomainObjects;
using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemonstrationProject.RawDataMappers
{
    public class FilmShowTimeMapper : IFilmShowTimeMapper
    {
        public List<DmFilmShowTime> MapRawFilmShowTimeToDomain(object rawFilmShowTime)
        {
            TinyMapper.Bind<List<CustomerDataWebService.RawFilmShowTime>, List<DmFilmShowTime>>();
            var showTimes = (CustomerDataWebService.RawFilmShowTime[])rawFilmShowTime;
            var domainShowTimes = TinyMapper.Map<List<DmFilmShowTime>>(showTimes.ToList());
            return domainShowTimes;
        }
    }
}