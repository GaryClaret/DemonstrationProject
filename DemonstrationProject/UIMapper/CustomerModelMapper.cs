using System.Linq;
using DemonstrationProject.DomainObjects;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;
using DemonstrationProject.Models;
using DemonstrationProject.Models.CustomerBillSubModels;
using Nelibur.ObjectMapper;

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
            TinyMapper.Bind<Statement, StatementModel>();
            var statementModel = TinyMapper.Map<StatementModel>(domainStatement);
            return statementModel;
        }

        private PeriodModel MapPeriodToDomainPeriod(Period dmPeriod)
        {
            TinyMapper.Bind<Period, PeriodModel>();
            var periodModel = TinyMapper.Map<PeriodModel>(dmPeriod);         

            return periodModel;
        }

        private SkyStoreModel MapSkyStoreToDomainObject(SkyStore dmSkyStore)
        {
            TinyMapper.Bind<SkyStore, SkyStoreModel>();
            var skyStoreModel = TinyMapper.Map<SkyStoreModel>(dmSkyStore);
            return skyStoreModel;
        }

        private RentalModel MapRentalDomainObject(Rental dmRental)
        {
            TinyMapper.Bind<Rental, RentalModel>();
            var rentalModel = TinyMapper.Map<RentalModel>(dmRental);
            return rentalModel;
        }

        private PackageModel MapPackageToDomainObject(Package dmPackage)
        {
            TinyMapper.Bind<Package, PackageModel>();
            var packageModel = TinyMapper.Map<PackageModel>(dmPackage);          
            return packageModel;
        }

        private SubscriptionModel MapSubscriptionsToDomainObject(Subscription dmSubscription)
        {
            TinyMapper.Bind<Subscription, SubscriptionModel>();
            var subscriptionModel = TinyMapper.Map<SubscriptionModel>(dmSubscription);        
            return subscriptionModel;
        }

        private CallChargesModel MapCallChargesToDomainObject(CallCharges dmCallCharges)
        {          
            TinyMapper.Bind<CallCharges, CallChargesModel>();
            var callChargesModel = TinyMapper.Map<CallChargesModel>(dmCallCharges);
            return callChargesModel;
        }

        private CallModel MapCallToDomainObject(Call dmCall)
        {
            TinyMapper.Bind<Call, CallModel>();
            var callModel = TinyMapper.Map<CallModel>(dmCall);         
            return callModel;
        }

        private BuyAndKeepModel MapBuyAndKeepToDomainObject(BuyAndKeep dmBuyAndKeep)
        {
            TinyMapper.Bind<BuyAndKeep, BuyAndKeepModel>();
            var buyAndKeepModel = TinyMapper.Map<BuyAndKeepModel>(dmBuyAndKeep);
            return buyAndKeepModel;
        }
    }
}