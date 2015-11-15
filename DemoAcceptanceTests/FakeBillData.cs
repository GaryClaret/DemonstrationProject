namespace DemoAcceptanceTests
{
    public static class FakeBillData
    {
        public static object GetFakeBill()
        {
            var bill = new DemonstrationProject.CustomerDataWebService.RawCustomerBill
            {
                Total = 70.20,
                CallCharges = GetCustomerCalls(),
                Package = GetCustomerSubscriptions(),
                Statement = GetCustomerStatement(),
                SkyStore = GetCustomerSkyStore()
            };

            return bill;
        }

        private static DemonstrationProject.CustomerDataWebService.Package GetCustomerSubscriptions()
        {
            var sub1 = new DemonstrationProject.CustomerDataWebService.Subscription
            {
                Type = "TV",
                Name = "Movies",
                Cost = 10.35
            };

            var sub2 = new DemonstrationProject.CustomerDataWebService.Subscription
            {
                Type = "Boardband",
                Name = "Fibre",
                Cost = 10.15
            };

            var package = new DemonstrationProject.CustomerDataWebService.Package
            {
                Total = 20.50,
                Subscriptions = new DemonstrationProject.CustomerDataWebService.Subscription[2] { sub1, sub2 }
            };
            return package;
        }

        private static DemonstrationProject.CustomerDataWebService.CallCharges GetCustomerCalls()
        {
            var call1 = new DemonstrationProject.CustomerDataWebService.Call
            {
                Called = "07716393769",
                Duration = "00:23:03",
                Cost = 10.00
            };

            var call2 = new DemonstrationProject.CustomerDataWebService.Call
            {
                Called = "07881671861",
                Duration = "00:13:03",
                Cost = 10.10
            };

            var callCharges = new DemonstrationProject.CustomerDataWebService.CallCharges
            {
                Total = 20.10,
                Calls = new DemonstrationProject.CustomerDataWebService.Call[2] { call1, call2 }
            };

            return callCharges;
        }

        private static DemonstrationProject.CustomerDataWebService.Statement GetCustomerStatement()
        {
            var period = new DemonstrationProject.CustomerDataWebService.Period
            {
                From = "2015-01-26",
                To = "2015-02-26"
            };

            var statement = new DemonstrationProject.CustomerDataWebService.Statement
            {
                Generated = "2015-01-11",
                Due = "2015-01-25",
                Period = period
            };

            return statement;
        }

        private static DemonstrationProject.CustomerDataWebService.SkyStore GetCustomerSkyStore()
        {
            var rental1 = new DemonstrationProject.CustomerDataWebService.Rental
            {
                Title = "Dodgeball",
                Cost = 2.00
            };

            var rental2 = new DemonstrationProject.CustomerDataWebService.Rental
            {
                Title = "Anchorman",
                Cost = 1.50
            };

            var buyAndKeep1 = new DemonstrationProject.CustomerDataWebService.BuyAndKeep
            {
                Title = "Interstellar",
                Cost = 13.00
            };

            var skyStore = new DemonstrationProject.CustomerDataWebService.SkyStore
            {
                Rentals = new DemonstrationProject.CustomerDataWebService.Rental[2] { rental1, rental2 },
                BuyAndKeep = new DemonstrationProject.CustomerDataWebService.BuyAndKeep[1] { buyAndKeep1 },
                Total = 16.50
            };

            return skyStore;
        }
    }
}
