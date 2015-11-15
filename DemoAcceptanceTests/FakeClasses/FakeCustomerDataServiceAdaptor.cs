using DemoAcceptanceTests;
using DemonstrationProject.Adaptors;
namespace DemoAcceptancetests.FakeClasses
{
    class FakeCustomerDataServiceAdaptor : ICustomerDataServiceAdaptor
    {
        public object ProvideCustomerBill()
        {
            return FakeBillData.GetFakeBill();
        }
    }
}
