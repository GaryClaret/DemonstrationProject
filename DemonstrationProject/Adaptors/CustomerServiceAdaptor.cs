using DemonstrationProject.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemonstrationProject.Adaptors
{
    public class CustomerDataServiceAdaptor : ICustomerDataServiceAdaptor
    {
        public DmCustomerBill ProvideCustomerBill()
        {
            throw new NotImplementedException();
        }
    }
}