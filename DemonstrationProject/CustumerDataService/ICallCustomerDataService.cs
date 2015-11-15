using DemonstrationProject.CustomerDataWebService;

namespace DemonstrationProject.CustumerDataService
{
    public interface ICallCustomerDataService
    {
        CustomerDataWebServiceClient Proxy { get; set; }
    }
}
