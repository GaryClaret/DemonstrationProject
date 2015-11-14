using System;
using Rhino.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemonstrationProject.Adaptors;

namespace DemoUnitTests
{
    [TestClass]
    public class ViewCustomerTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            SimpleInjectorImpl dependencyInj = new SimpleInjectorImpl();
            dependencyInj.MapInterfacesToImplementations();
        }

        [TestMethod]
        public void WhenContactWebServiceReturnCustomerData()
        {
            //Arrange
            var adaptor = MockRepository.GenerateMock<ICustomerDataServiceAdaptor>();
            //Act
            object returnedBill = adaptor.Stub(a => a.ProvideCustomerBill()).Return(FakeBillData.GetFakeBill());
            //Assert
            Assert.IsNotNull(returnedBill);
        }

        [TestMethod]
        public void WhenRawCustomerReceivedFromWebServiceMapToDomainObject()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void WhenCustomerRequestFromBusinessLogicThenReturnCustomer()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void WhenCustomerRequestedFromBusinessLogicThenMapToCustomerModel()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void WhenCustomerRequestedFromBusinessModelThenCustomerModelReturned()
        {
            Assert.IsTrue(false);
        }
    }
}
