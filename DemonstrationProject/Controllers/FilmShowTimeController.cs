using DemonstrationProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemonstrationProject.Controllers
{
    public class FilmShowTimeController : Controller
    {
        private readonly IFilmShowTimeBl _filmShowTimeBusiness;

        public FilmShowTimeController(IFilmShowTimeBl filmShowTimeBusiness)
        {
            _filmShowTimeBusiness = filmShowTimeBusiness;
        }

        public ActionResult Index()
        {
            var domainShowtimes = _filmShowTimeBusiness.ProvideFilmShowTimes();
            var model = _filmShowTimeBusiness.ProvideFilmShowTimeModel(domainShowtimes);
            return View("FilmShowTimes", model);
        }

    }
}
