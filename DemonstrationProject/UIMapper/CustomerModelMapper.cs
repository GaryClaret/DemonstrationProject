using System.Linq;
using DemonstrationProject.DomainObjects;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;
using DemonstrationProject.Models;
using DemonstrationProject.Models.CustomerBillSubModels;

namespace DemonstrationProject.UIMapper
{
    public class CustomerModelMapper : ICustomerModelMapper
    {
        public CustomerBillModel Map(DmCustomerBill domainBill)
        {
            var billModel = new CustomerBillModel
            {
                CallCharges = MapCallChargesToDomainObject(domainBill.CallCharges),
                Package = MapPackageToDomainObject(domainBill.Package),
                SkyStore = MapSkyStoreToDomainObject(domainBill.SkyStore),
                Statement = MapStatementToDomainStatement(domainBill.Statement),
                Total = domainBill.Total
            };

            return billModel;
        }      

        private StatementModel MapStatementToDomainStatement(Statement domainStatement)
        {
            var statementModel = new StatementModel
            {
                Due = domainStatement.Due,
                Generated = domainStatement.Generated,
                Period = MapPeriodToDomainPeriod(domainStatement.Period)
            };

            return statementModel;
        }

        private PeriodModel MapPeriodToDomainPeriod(Period dmPeriod)
        {
            var periodModel = new PeriodModel
            {
                From = dmPeriod.From,
                To = dmPeriod.To
            };

            return periodModel;
        }

        private SkyStoreModel MapSkyStoreToDomainObject(SkyStore dmSkyStore)
        {
            var skyStoreModel = new SkyStoreModel
            {
                BuyAndKeep = dmSkyStore.BuyAndKeep.Select(MapBuyAndKeepToDomainObject).ToArray(),
                Total = dmSkyStore.Total,
                Rentals = dmSkyStore.Rentals.Select(MapRentalDomainObject).ToArray()
            };

            return skyStoreModel;
        }

        private RentalModel MapRentalDomainObject(Rental dmRental)
        {
            var rentalModel = new RentalModel
            {
                Cost = dmRental.Cost,
                Title = dmRental.Title
            };

            return rentalModel;
        }

        private PackageModel MapPackageToDomainObject(Package dmPackage)
        {
            var packageModel = new PackageModel
            {
                Subscriptions = dmPackage.Subscriptions.Select(MapSubscriptionsToDomainObject).ToArray(),
                Total = dmPackage.Total
            };

            return packageModel;
        }

        private SubscriptionModel MapSubscriptionsToDomainObject(Subscription dmSubscription)
        {
            var subscriptionModel = new SubscriptionModel
            {
                Cost = dmSubscription.Cost,
                Name = dmSubscription.Name,
                Type = dmSubscription.Type
            };

            return subscriptionModel;
        }

        private CallChargesModel MapCallChargesToDomainObject(CallCharges dmCallCharges)
        {          
            var CallChargesModel = new CallChargesModel
            {
                Calls = dmCallCharges.Calls.Select(MapCallToDomainObject).ToArray(),
                Total = dmCallCharges.Total
            };

            return CallChargesModel;
        }

        private CallModel MapCallToDomainObject(Call dmCall)
        {           
            var callModel = new CallModel
            {
                Called = dmCall.Called,
                Cost = dmCall.Cost,
                Duration = dmCall.Duration
            };

            return callModel;
        }

        private BuyAndKeepModel MapBuyAndKeepToDomainObject(BuyAndKeep dmBuyAndKeep)
        {
            var buyAndKeepModel = new BuyAndKeepModel
            {
                Cost = dmBuyAndKeep.Cost,
                Title = dmBuyAndKeep.Title
            };

            return buyAndKeepModel;
        }
    }
}