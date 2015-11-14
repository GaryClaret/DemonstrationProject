
using DemonstrationProject.BusinessLogic;
using DemonstrationProject.Models;
using DemonstrationProject.UIMapper;

namespace DemonstrationProject.UIControllers
{
    public class UICustomerBillController
    {
        private readonly ICustomerBl _customerBillBusiness;
        private readonly ICustomerModelMapper _customerBillModelMapper;

        public UICustomerBillController(ICustomerBl customerBillBillbusiness, ICustomerModelMapper customerBillModelMapper)
        {
            _customerBillBusiness = customerBillBillbusiness;
            _customerBillModelMapper = customerBillModelMapper;
        }

        public CustomerBillModel GetCustomerBillModel()
        {
            var domainCustomerBill = _customerBillBusiness.ProvideCustomerBill();
            return _customerBillModelMapper.Map(domainCustomerBill);
        }
    }
}