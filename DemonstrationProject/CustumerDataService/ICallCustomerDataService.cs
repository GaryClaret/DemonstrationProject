using DemonstrationProject.CustomerDataService;

namespace DemonstrationProject.CustumerDataService
{
    public interface ICallCustomerDataService
    {
        CustomerDataWebServiceClient Proxy { get; set; }
    }
}
