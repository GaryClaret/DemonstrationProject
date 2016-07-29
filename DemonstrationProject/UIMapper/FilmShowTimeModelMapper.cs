using DemonstrationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemonstrationProject.UIMapper
{
    public class FilmShowTimeModelMapper : IFilmShowTimeModelMapper
    {
        public FilmShowTimeModel Map(string filmTitle, string directors, string longDescription)
        {
            FilmShowTimeModel model = new FilmShowTimeModel
            {
                title = filmTitle,
                longDesc = longDescription,
                director = directors
            };

            return model;
        }
    }
}