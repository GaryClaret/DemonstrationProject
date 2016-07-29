using DemonstrationProject.Adaptors;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemonstrationProject.BusinessLogic;
using DemonstrationProject.CustumerDataService;
using DemonstrationProject.RawDataMappers;
using DemonstrationProject.UIMapper;

namespace DemonstrationProject.App_Start
{
    public class SimpleInjectorImpl
    {
        public Container container { get; set; }

        public void MapInterfacesToImplementations()
        {
            container = new Container();

            container.Register<ICustomerBl,CustomerBl>();
            container.Register<ICustomerBillMapper, CustomerBillMapper>();
            container.Register<ICustomerModelMapper,CustomerModelMapper>();
            container.Register<ICustomerDataServiceAdaptor, CustomerDataServiceAdaptor>();

            container.Register<IFilmShowTimeBl, FilmShowTimeBl>();
            container.Register<IFilmShowTimeMapper, FilmShowTimeMapper>();
            container.Register<IFilmShowTimeModelMapper, FilmShowTimeModelMapper>();
            
            container.Register<ICallCustomerDataService,CallDataService>(Lifestyle.Singleton);
            
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));   
        }
    }
}