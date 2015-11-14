using DemonstrationProject.DomainObjects;
using DemonstrationProject.Models;

namespace DemonstrationProject.UIMapper
{
    public interface ICustomerModelMapper
    {
        CustomerBillModel Map(DmCustomerBill domainBill);
    }
}
