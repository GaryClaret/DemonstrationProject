using DemonstrationProject.CustumerDataService;
using DemonstrationProject.RawDataMappers;

namespace DemonstrationProject.Adaptors
{
    public class CustomerDataServiceAdaptor : ICustomerDataServiceAdaptor
    {
        private readonly ICallCustomerDataService _customerDataService;

        public CustomerDataServiceAdaptor(ICallCustomerDataService customerDataService)
        {
            _customerDataService = customerDataService;
        }

        public object ProvideCustomerBill()
        {
           return _customerDataService.Proxy.GetCustomerBill();
        }


        public object ProvideFilmShowTimes()
        {
            return _customerDataService.Proxy.GetFilmShowTimes();
        }
    }
}