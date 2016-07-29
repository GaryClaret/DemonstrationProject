using DemonstrationProject.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationProject.RawDataMappers
{
    public interface IFilmShowTimeMapper
    {
        List<DmFilmShowTime> MapRawFilmShowTimeToDomain(object rawFilmShowTime);
    }
}
