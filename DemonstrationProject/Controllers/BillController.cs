using DemonstrationProject.BusinessLogic;
using System.Web.Mvc;
using DemonstrationProject.UIMapper;

namespace DemonstrationProject.Controllers
{
    public class BillController : Controller
    {
        private readonly ICustomerBl _customerBillBusiness;
        private readonly ICustomerModelMapper _customerBillModelMapper;

        public BillController(ICustomerBl customerBillBillbusiness, ICustomerModelMapper customerBillModelMapper)
        {
            _customerBillBusiness = customerBillBillbusiness;
            _customerBillModelMapper = customerBillModelMapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var domainCustomerBill = _customerBillBusiness.ProvideCustomerBill();
            var customerBillModel = _customerBillModelMapper.Map(domainCustomerBill);

            return View("",customerBillModel);
        }
    }
}
