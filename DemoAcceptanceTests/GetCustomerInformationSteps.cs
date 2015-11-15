using DemonstrationProject.BusinessLogic;
using DemonstrationProject.Models;
using DemonstrationProject.RawDataMappers;
using DemonstrationProject.UIMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace DemoAcceptanceTests
{
    [Binding]
    public class GetCustomerInformationSteps
    {
        [Given(@"I have entered the account screen")]
        public void GivenIHaveEnteredTheAccountScreen()
        {
            SimpleInjectorImpl injectImplementations = new SimpleInjectorImpl();
            injectImplementations.MapInterfacesToImplementations();
            var customerBusiness = injectImplementations.container.GetRegistration(typeof (ICustomerBl));
            var customerMapper = injectImplementations.container.GetRegistration(typeof (ICustomerModelMapper));
            ScenarioContext.Current.Add("businesslogic", (ICustomerBl) customerBusiness.GetInstance());
            ScenarioContext.Current.Add("mapper",customerMapper.GetInstance());
        }

        [When(@"I click to view my bill")]
        public void WhenIClickToViewMyBill()
        {
            var businessLogic = ScenarioContext.Current.Get<ICustomerBl>("businesslogic");
            var mapper = ScenarioContext.Current.Get<ICustomerModelMapper>("mapper");

            ScenarioContext.Current.Add("model", mapper.Map(businessLogic.ProvideCustomerBill()));
        }

        [Then(@"the correct bill details should be displayed on the screen")]
        public void ThenTheCorrectBillDetailsShouldBeDisplayedOnTheScreen()
        {
            var model = ScenarioContext.Current.Get<CustomerBillModel>("model");
            Assert.IsNotNull(model);
        }
    }
}
