using DemonstrationProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemonstrationProject.Controllers
{
    public class BillController : Controller
    {
        private ICustomerBl _customerBusiness;
        private 

        public BillController()
 
        [HttpGet]
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
