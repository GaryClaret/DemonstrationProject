using System;
using Rhino.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemonstrationProject.Adaptors;
using DemonstrationProject.BusinessLogic;
using DemonstrationProject.RawDataMappers;
using DemonstrationProject.UIMapper;

namespace DemoUnitTests
{
    [TestClass]
    public class ViewCustomerTests
    {
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
            //Arrange
            var adaptor = MockRepository.GenerateMock<ICustomerDataServiceAdaptor>();
            adaptor.Stub(a => a.ProvideCustomerBill()).Return(FakeBillData.GetFakeBill());
            var mapper = new CustomerBillMapper();
            var businessLogic = new CustomerBl(mapper,adaptor);

            //Act
            var domainBill = businessLogic.ProvideCustomerBill();

            //Assert
            Assert.IsNotNull(domainBill);
            Assert.IsNotNull(domainBill.CallCharges);
            Assert.IsNotNull(domainBill.CallCharges.Calls);
            Assert.IsTrue(domainBill.CallCharges.Total > 0);
            Assert.IsNotNull(domainBill.Package);
            Assert.IsNotNull(domainBill.Package.Subscriptions);
            Assert.IsTrue(domainBill.Package.Total > 0);
            Assert.IsNotNull(domainBill.SkyStore);
            Assert.IsNotNull(domainBill.SkyStore.BuyAndKeep);
            Assert.IsNotNull(domainBill.SkyStore.Rentals);
            Assert.IsTrue(domainBill.SkyStore.Total > 0);
            Assert.IsTrue(!String.IsNullOrEmpty(domainBill.Statement.Due));
            Assert.IsTrue(!String.IsNullOrEmpty(domainBill.Statement.Generated));
            Assert.IsNotNull(domainBill.Statement.Period);
            Assert.IsTrue(!String.IsNullOrEmpty(domainBill.Statement.Period.To));
            Assert.IsTrue(!String.IsNullOrEmpty(domainBill.Statement.Period.From));
            Assert.IsNotNull((domainBill.Statement));
            Assert.IsTrue(domainBill.Total > 0);
        }

        [TestMethod]
        public void WhenCustomerRequestFromBusinessLogicThenReturnCustomer()
        {
            //Arrange
            var adaptor = MockRepository.GenerateMock<ICustomerDataServiceAdaptor>();
            adaptor.Stub(a => a.ProvideCustomerBill()).Return(FakeBillData.GetFakeBill());
            var mapper = new CustomerBillMapper();
            var businessLogic = new CustomerBl(mapper, adaptor);

            //Act
            var domainCustomer = businessLogic.ProvideCustomerBill();

            //Assert
            Assert.IsNotNull(domainCustomer);
        }

        [TestMethod]
        public void WhenCustomerRequestedFromBusinessLogicThenMapToCustomerModel()
        {
            //Arrange
            var adaptor = MockRepository.GenerateMock<ICustomerDataServiceAdaptor>();
            adaptor.Stub(a => a.ProvideCustomerBill()).Return(FakeBillData.GetFakeBill());
            var mapper = new CustomerBillMapper();
            var modelMapper = new CustomerModelMapper();
            var businessLogic = new CustomerBl(mapper, adaptor);

            //Act
            var domainModel = businessLogic.ProvideCustomerBill();
            var customerBillModel = modelMapper.Map(domainModel);

            //Assert
            Assert.IsNotNull(customerBillModel);
            Assert.IsNotNull(customerBillModel.CallCharges);
            Assert.IsNotNull(customerBillModel.CallCharges.Calls);
            Assert.IsTrue(customerBillModel.CallCharges.Total > 0);
            Assert.IsNotNull(customerBillModel.Package);
            Assert.IsNotNull(customerBillModel.Package.Subscriptions);
            Assert.IsTrue(customerBillModel.Package.Total > 0);
            Assert.IsNotNull(customerBillModel.SkyStore);
            Assert.IsNotNull(customerBillModel.SkyStore.BuyAndKeep);
            Assert.IsNotNull(customerBillModel.SkyStore.Rentals);
            Assert.IsTrue(customerBillModel.SkyStore.Total > 0);
            Assert.IsTrue(!String.IsNullOrEmpty(customerBillModel.Statement.Due));
            Assert.IsTrue(!String.IsNullOrEmpty(customerBillModel.Statement.Generated));
            Assert.IsNotNull(customerBillModel.Statement.Period);
            Assert.IsTrue(!String.IsNullOrEmpty(customerBillModel.Statement.Period.To));
            Assert.IsTrue(!String.IsNullOrEmpty(customerBillModel.Statement.Period.From));
            Assert.IsNotNull((customerBillModel.Statement));
            Assert.IsTrue(customerBillModel.Total > 0);
        }

        [TestMethod]
        public void WhenCustomerRequestedFromBusinessModelThenCustomerModelReturned()
        {
            //Arrange
            var adaptor = MockRepository.GenerateMock<ICustomerDataServiceAdaptor>();
            adaptor.Stub(a => a.ProvideCustomerBill()).Return(FakeBillData.GetFakeBill());
            var mapper = new CustomerBillMapper();
            var modelMapper = new CustomerModelMapper();
            var businessLogic = new CustomerBl(mapper, adaptor);

            //Act
            var domainModel = businessLogic.ProvideCustomerBill();
            var customerBillModel = modelMapper.Map(domainModel);

            //Assert
            Assert.IsNotNull(customerBillModel);          
        }
    }
}
