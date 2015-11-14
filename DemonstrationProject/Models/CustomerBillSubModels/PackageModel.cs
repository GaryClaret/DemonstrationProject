namespace DemonstrationProject.Models.CustomerBillSubModels
{

    public class PackageModel
    {
        public SubscriptionModel[] Subscriptions { get; set; }
        public double Total { get; set; }
    }

}
