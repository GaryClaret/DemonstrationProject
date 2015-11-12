using DemonstrationProject.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemonstrationProject.Adaptors
{
    public class CustomerDataServiceAdaptor : ICustomerDataServiceAdaptor
    {
        public object ProvideCustomerBill()
        {
            throw new NotImplementedException();
        }
    }
}