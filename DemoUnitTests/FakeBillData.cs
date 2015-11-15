namespace DemoUnitTests
{
    public static class FakeBillData
    {
        public static object GetFakeBill()
        {
            var bill = new DemonstrationProject.CustomerDataService.RawCustomerBill
            {
                Total = 70.20,
                CallCharges = GetCustomerCalls(),
                Package = GetCustomerSubscriptions(),
                Statement = GetCustomerStatement(),
                SkyStore = GetCustomerSkyStore()
            };

            return bill;
        }

        private static DemonstrationProject.CustomerDataService.Package GetCustomerSubscriptions()
        {
            var sub1 = new DemonstrationProject.CustomerDataService.Subscription
            {
                Type = "TV",
                Name = "Movies",
                Cost = 10.35
            };

            var sub2 = new DemonstrationProject.CustomerDataService.Subscription
            {
                Type = "Boardband",
                Name = "Fibre",
                Cost = 10.15
            };

            var package = new DemonstrationProject.CustomerDataService.Package
            {
                Total = 20.50,
                Subscriptions = new DemonstrationProject.CustomerDataService.Subscription[2] { sub1, sub2 }
            };
            return package;
        }

        private static DemonstrationProject.CustomerDataService.CallCharges GetCustomerCalls()
        {
            var call1 = new DemonstrationProject.CustomerDataService.Call
            {
                Called = "07716393769",
                Duration = "00:23:03",
                Cost = 10.00
            };

            var call2 = new DemonstrationProject.CustomerDataService.Call
            {
                Called = "07881671861",
                Duration = "00:13:03",
                Cost = 10.10
            };

            var callCharges = new DemonstrationProject.CustomerDataService.CallCharges
            {
                Total = 20.10,
                Calls = new DemonstrationProject.CustomerDataService.Call[2] { call1, call2 }
            };

            return callCharges;
        }

        private static DemonstrationProject.CustomerDataService.Statement GetCustomerStatement()
        {
            var period = new DemonstrationProject.CustomerDataService.Period
            {
                From = "2015-01-26",
                To = "2015-02-26"
            };

            var statement = new DemonstrationProject.CustomerDataService.Statement
            {
                Generated = "2015-01-11",
                Due = "2015-01-25",
                Period = period
            };

            return statement;
        }

        private static DemonstrationProject.CustomerDataService.SkyStore GetCustomerSkyStore()
        {
            var rental1 = new DemonstrationProject.CustomerDataService.Rental
            {
                Title = "Dodgeball",
                Cost = 2.00
            };

            var rental2 = new DemonstrationProject.CustomerDataService.Rental
            {
                Title = "Anchorman",
                Cost = 1.50
            };

            var buyAndKeep1 = new DemonstrationProject.CustomerDataService.BuyAndKeep
            {
                Title = "Interstellar",
                Cost = 13.00
            };

            var skyStore = new DemonstrationProject.CustomerDataService.SkyStore
            {
                Rentals = new DemonstrationProject.CustomerDataService.Rental[2] { rental1, rental2 },
                BuyAndKeep = new DemonstrationProject.CustomerDataService.BuyAndKeep[1] { buyAndKeep1 },
                Total = 16.50
            };

            return skyStore;
        }
    }
}
