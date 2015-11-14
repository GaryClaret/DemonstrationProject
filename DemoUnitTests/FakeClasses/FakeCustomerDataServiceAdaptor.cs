using DemonstrationProject.Adaptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTests.FakeClasses
{
    class FakeCustomerDataServiceAdaptor : ICustomerDataServiceAdaptor
    {
        public object ProvideCustomerBill()
        {
            return FakeBillData.GetFakeBill();
        }
    }
}
