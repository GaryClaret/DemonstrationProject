﻿using DemonstrationProject.CustomerDataWebService;

namespace DemonstrationProject.CustumerDataService
{
    public class CallDataService : ICallCustomerDataService
    {
        public CustomerDataWebServiceClient Proxy { get;set;}

        public CallDataService()
        {
            Proxy = new CustomerDataWebServiceClient();
        }
    }
}