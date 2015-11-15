using DemonstrationProject.Adaptors;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;
using DemoAcceptancetests.FakeClasses;
using DemonstrationProject.BusinessLogic;
using DemonstrationProject.RawDataMappers;
using DemonstrationProject.UIMapper;

namespace DemoAcceptanceTests
{
    public class SimpleInjectorImpl
    {
        public Container container { get; set; }

        public void MapInterfacesToImplementations()
        {
            container = new Container();
            container.Register<ICustomerDataServiceAdaptor, FakeCustomerDataServiceAdaptor>();
            container.Register<ICustomerBl, CustomerBl>();
            container.Register<ICustomerBillMapper, CustomerBillMapper>();
            container.Register<ICustomerModelMapper, CustomerModelMapper>();

            container.Verify();
        }
    }
}