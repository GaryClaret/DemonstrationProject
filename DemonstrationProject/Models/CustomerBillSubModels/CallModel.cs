using Newtonsoft.Json;

namespace DemonstrationProject.Models.CustomerBillSubModels
{
    public class CallModel
    {
        public string Called { get; set; }
        public string Duration { get; set; }
        public double Cost { get; set; }
    }
}
