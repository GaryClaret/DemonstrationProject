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
            return View("ReactFilmShowTimes");
        }

        [HttpGet]
        public ActionResult Showtimes()
        {
            var showtimeDate = "2016-08-17";
            var domainShowtimes = _filmShowTimeBusiness.ProvideFilmShowTimes(showtimeDate);
            var model = _filmShowTimeBusiness.ProvideFilmShowTimeModel(domainShowtimes);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowtimesWithDate()
        {
            var domainShowtimes = _filmShowTimeBusiness.ProvideFilmShowTimes(this.HttpContext.Request.Params["dateOfShowings"]);
            var model = _filmShowTimeBusiness.ProvideFilmShowTimeModel(domainShowtimes);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
