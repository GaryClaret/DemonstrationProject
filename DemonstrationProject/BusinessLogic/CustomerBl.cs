using DemonstrationProject.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemonstrationProject.Adaptors;
using DemonstrationProject.Models;
using DemonstrationProject.RawDataMappers;
using DemonstrationProject.UIMapper;

namespace DemonstrationProject.BusinessLogic
{
    public class CustomerBl : ICustomerBl
    {
        private readonly ICustomerBillMapper _customerBillMapper;
        private readonly ICustomerDataServiceAdaptor _customerDataServiceAdaptor;

        public CustomerBl(ICustomerBillMapper customerBillMapper, ICustomerDataServiceAdaptor customerDataServiceAdaptor)
        {
            _customerBillMapper = customerBillMapper;
            _customerDataServiceAdaptor = customerDataServiceAdaptor;
        }

        public DmCustomerBill ProvideCustomerBill()
        {
           return _customerBillMapper.MapRawBillToDomainObject(_customerDataServiceAdaptor.ProvideCustomerBill());
        }
    }
}