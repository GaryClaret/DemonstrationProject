using DemonstrationProject.DomainObjects;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;
using System.Linq;

namespace DemonstrationProject.RawDataMappers
{
    public class CustomerBillMapper : ICustomerBillMapper
    {
        public DmCustomerBill MapRawBillToDomainObject(object rawCustomerBill)
        {
           var bill = (CustomerDataService.RawCustomerBill)rawCustomerBill;

           DmCustomerBill domainBill = new DmCustomerBill
           {
               CallCharges = MapCallChargesToDomainObject(bill.CallCharges),        
               Package = MapPackageToDomainObject(bill.Package),
               SkyStore = MapSkyStoreToDomainObject(bill.SkyStore),
               Statement = MapStatementToDomainStatement(bill.Statement),
               Total = bill.Total
           };

            return domainBill;
        }

        private Statement MapStatementToDomainStatement(object rawStatement)
        {
            var statement = (CustomerDataService.Statement)rawStatement;

            Statement domainStatement = new Statement
            {
                Due = statement.Due,
                Generated = statement.Generated,
                Period = MapPeriodToDomainPeriod(statement.Period)
            };

            return domainStatement;
        }

        private Period MapPeriodToDomainPeriod(object rawPeriod)
        {
            var period = (CustomerDataService.Period)rawPeriod;

            Period domainPeriod = new Period
            {
                From = period.From,
                To = period.To
            };

            return domainPeriod;
        }

        private SkyStore MapSkyStoreToDomainObject(object rawSkyStore)
        {
            var skyStore = (CustomerDataService.SkyStore)rawSkyStore;

            SkyStore domainSkyStore = new SkyStore
            {
                BuyAndKeep = skyStore.BuyAndKeep.Select(MapBuyAndKeepToDomainObject).ToArray(),
                Total = skyStore.Total,
                Rentals = skyStore.Rentals.Select(MapRentalDomainObject).ToArray()
            };

            return domainSkyStore;
        }

        private Rental MapRentalDomainObject(object rawRental)
        {
            var rental = (CustomerDataService.Rental)rawRental;

            var domainrental = new Rental
            {
                Cost = rental.Cost,
                Title = rental.Title
            };

            return domainrental;
        }

        private Package MapPackageToDomainObject(object rawPackage)
        {
            var package = (CustomerDataService.Package)rawPackage;

            Package domainPackage = new Package
            {
                Subscriptions = package.Subscriptions.Select(MapSubscriptionsToDomainObject).ToArray(),
                Total = package.Total
            };

            return domainPackage;
        }

        private Subscription MapSubscriptionsToDomainObject(object rawSubscription)
        {
            var subscription = (CustomerDataService.Subscription)rawSubscription;

            Subscription domainSubscription = new Subscription
            {
                Cost = subscription.Cost,
                Name = subscription.Name,
                Type = subscription.Type
            };

            return domainSubscription;
        }

        private CallCharges MapCallChargesToDomainObject(object rawCallCharges)
        {
            var callCharges = (CustomerDataService.CallCharges)rawCallCharges;

            CallCharges domainCallCharges = new CallCharges
            {
                Calls = callCharges.Calls.Select(MapCallToDomainObject).ToArray(),
                Total = callCharges.Total
            };

            return domainCallCharges;
        }

        private Call MapCallToDomainObject(object rawCall)
        {
            var call = (CustomerDataService.Call)rawCall;

            Call domainCall = new Call
            {
                Called = call.Called,
                Cost = call.Cost,
                Duration = call.Duration
            };

            return domainCall;
        }

        private BuyAndKeep MapBuyAndKeepToDomainObject(object rawBuyAndKeep)
        {
            var buyAndKeep = (CustomerDataService.BuyAndKeep)rawBuyAndKeep;

            BuyAndKeep domainBuyAndKeep = new BuyAndKeep
            {
                Cost = buyAndKeep.Cost,
                Title = buyAndKeep.Title
            };

            return domainBuyAndKeep;
        }
    }
}