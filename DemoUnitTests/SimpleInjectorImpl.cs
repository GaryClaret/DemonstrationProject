using DemonstrationProject.Adaptors;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoUnitTests
{
    public class SimpleInjectorImpl
    {
        public Container container { get; set; }

        public void MapInterfacesToImplementations()
        {
            container = new Container();
            container.Register<ICustomerDataServiceAdaptor, CustomerDataServiceAdaptor>();
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}