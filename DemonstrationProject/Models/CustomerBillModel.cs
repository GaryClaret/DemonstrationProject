using DemonstrationProject.Models.CustomerBillSubModels;

namespace DemonstrationProject.Models
{
    public class CustomerBillModel
    {
        public StatementModel Statement { get; set; }

        public double Total { get; set; }

        public PackageModel Package { get; set; }

        public CallChargesModel CallCharges { get; set; }

        public SkyStoreModel SkyStore { get; set; }
    }

}
