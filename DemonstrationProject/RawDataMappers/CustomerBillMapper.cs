using DemonstrationProject.DomainObjects;
using DemonstrationProject.DomainObjects.DmCustomerBillJsonTypes;
using Nelibur.ObjectMapper;
using System.Linq;

namespace DemonstrationProject.RawDataMappers
{
    public class CustomerBillMapper : ICustomerBillMapper
    {
        public DmCustomerBill MapRawBillToDomainObject(object rawCustomerBill)
        {
            var bill = (CustomerDataWebService.RawCustomerBill)rawCustomerBill;

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
            var statement = (CustomerDataWebService.Statement)rawStatement;

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
            TinyMapper.Bind<CustomerDataWebService.Period, Period>();
            var period = (CustomerDataWebService.Period)rawPeriod;
            var domainPeriod = TinyMapper.Map<Period>(period);

            return domainPeriod;
        }

        private SkyStore MapSkyStoreToDomainObject(object rawSkyStore)
        {
            TinyMapper.Bind<CustomerDataWebService.SkyStore, SkyStore>();
            var skyStore = (CustomerDataWebService.SkyStore)rawSkyStore;
            var domainSkyStore = TinyMapper.Map<SkyStore>(skyStore);

            return domainSkyStore;
        }

        private Rental MapRentalDomainObject(object rawRental)
        {
            TinyMapper.Bind<CustomerDataWebService.Rental, Rental>();
            var rental = (CustomerDataWebService.Rental)rawRental;
            var domainRental = TinyMapper.Map<Rental>(rental);

            return domainRental;
        }

        private Package MapPackageToDomainObject(object rawPackage)
        {
            TinyMapper.Bind<CustomerDataWebService.Package, Package>();
            var package = (CustomerDataWebService.Package)rawPackage;
            var domainPackage = TinyMapper.Map<Package>(package);

            return domainPackage;
        }

        private Subscription MapSubscriptionsToDomainObject(object rawSubscription)
        {
            TinyMapper.Bind<CustomerDataWebService.Subscription, Subscription>();
            var subscription = (CustomerDataWebService.Subscription)rawSubscription;
            var domainSubscription = TinyMapper.Map<Subscription>(subscription);

            return domainSubscription;
        }

        private CallCharges MapCallChargesToDomainObject(object rawCallCharges)
        {
            TinyMapper.Bind<CustomerDataWebService.CallCharges, CallCharges>();
            var callCharges = (CustomerDataWebService.CallCharges)rawCallCharges;
            var domainCallCharges = TinyMapper.Map<CallCharges>(callCharges);

            return domainCallCharges;
        }

        private Call MapCallToDomainObject(object rawCall)
        {
            TinyMapper.Bind<CustomerDataWebService.Call, Call>();
            var call = (CustomerDataWebService.Call)rawCall;
            var domainCall = TinyMapper.Map<Call>(call);

            return domainCall;
        }

        private BuyAndKeep MapBuyAndKeepToDomainObject(object rawBuyAndKeep)
        {
            TinyMapper.Bind<CustomerDataWebService.BuyAndKeep, BuyAndKeep>();
            var buyAndKeep = (CustomerDataWebService.BuyAndKeep)rawBuyAndKeep;
            var domainBuyAndKeep = TinyMapper.Map<BuyAndKeep>(buyAndKeep);

            return domainBuyAndKeep;
        }
    }
}