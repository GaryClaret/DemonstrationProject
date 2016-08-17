using DemonstrationProject.DomainObjects;
using DemonstrationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationProject.BusinessLogic
{
    public interface IFilmShowTimeBl
    {
        List<DmFilmShowTime> ProvideFilmShowTimes(string dateOfShowings);
        FilmHeaderModel ProvideFilmShowTimeModel(List<DmFilmShowTime> domainFilmTimesList);
    }
}
