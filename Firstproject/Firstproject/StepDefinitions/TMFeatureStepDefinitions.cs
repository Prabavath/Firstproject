using System;
using TechTalk.SpecFlow;

namespace Firstproject.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
