namespace DemonstrationProject.Models.CustomerBillSubModels
{

    public class SkyStoreModel
    {
        public RentalModel[] Rentals { get; set; }
        public BuyAndKeepModel[] BuyAndKeep { get; set; }
        public double Total { get; set; }
    }

}
