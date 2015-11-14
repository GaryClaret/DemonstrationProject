using DemonstrationProject.RawDataObjects;
using DemonstrationProject.RawDataObjects.RawCustomerBillJsonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTests
{
    public static class FakeBillData
    {
        public static object GetFakeBill()
        {
            RawCustomerBill bill = new RawCustomerBill();
            bill.Total = 70.20;
            bill.CallCharges = GetCustomerCalls();
            bill.Package = GetCustomerSubscriptions();
            bill.Statement = GetCustomerStatement();
            bill.SkyStore = GetCustomerSkyStore();

            return bill;
        }

        private static RawPackage GetCustomerSubscriptions()
        {
            RawSubscription sub1 = new RawSubscription
            {
                Type = "TV",
                Name = "Movies",
                Cost = 10.35
            };

            RawSubscription sub2 = new RawSubscription
            {
                Type = "Boardband",
                Name = "Fibre",
                Cost = 10.15
            };

            RawPackage package = new RawPackage
            {
                Total = 20.50,
                Subscriptions = new RawSubscription[2] { sub1, sub2 }
            };
            return package;
        }

        private static RawCallCharges GetCustomerCalls()
        {
            RawCall call1 = new RawCall
            {
                Called = "07716393769",
                Duration = "00:23:03",
                Cost = 10.00
            };

            RawCall call2 = new RawCall
            {
                Called = "07881671861",
                Duration = "00:13:03",
                Cost = 10.10
            };

            RawCallCharges callCharges = new RawCallCharges
            {
                Total = 20.10,
                Calls = new RawCall[2] { call1, call2 }
            };
            return callCharges;
        }

        private static RawStatement GetCustomerStatement()
        {
            RawPeriod period = new RawPeriod
            {
                From = "2015-01-26",
                To = "2015-02-26"
            };

            RawStatement statement = new RawStatement
            {
                Generated = "2015-01-11",
                Due = "2015-01-25",
                Period = period
            };

            return statement;
        }

        private static RawSkyStore GetCustomerSkyStore()
        {
            RawRental rental1 = new RawRental
            {
                Title = "Dodgeball",
                Cost = 2.00
            };

            RawRental rental2 = new RawRental
            {
                Title = "Anchorman",
                Cost = 1.50
            };

            RawBuyAndKeep buyAndKeep1 = new RawBuyAndKeep
            {
                Title = "Interstellar",
                Cost = 13.00
            };

            RawSkyStore skyStore = new RawSkyStore
            {
                Rentals = new RawRental[2] { rental1, rental2 },
                BuyAndKeep = new RawBuyAndKeep[1]{buyAndKeep1},
                Total = 16.50
            };

            return skyStore;
        }
    }
}
