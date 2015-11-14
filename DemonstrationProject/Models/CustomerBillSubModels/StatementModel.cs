namespace DemonstrationProject.Models.CustomerBillSubModels
{
    public class StatementModel
    {
        public string Generated { get; set; }
        public string Due { get; set; }
        public PeriodModel Period { get; set; }
    }

}
