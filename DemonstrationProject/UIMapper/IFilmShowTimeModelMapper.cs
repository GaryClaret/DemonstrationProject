using DemonstrationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationProject.UIMapper
{
    public interface IFilmShowTimeModelMapper
    {
        FilmShowTimeModel Map(string filmTitle, string directors, string longDescription);
    }
}
