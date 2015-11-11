using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemonstrationProject.Controllers
{
    public class BillController : Controller
    {
 
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index()
        {          
            return View();
        }

        public ActionResult ViewBill()
        {

            return View();
        }
    }
}
