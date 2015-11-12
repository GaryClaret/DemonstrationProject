using System;
using TechTalk.SpecFlow;

namespace DemoAcceptanceTests
{
    [Binding]
    public class GetCustomerInformationSteps
    {
        [Given(@"I have entered the account screen")]
        public void GivenIHaveEnteredTheAccountScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click to view my bill")]
        public void WhenIClickToViewMyBill()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the correct bill details should be displayed on the screen")]
        public void ThenTheCorrectBillDetailsShouldBeDisplayedOnTheScreen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
