using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Task.Delay(TimeSpan.FromSeconds(1)).Wait();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
        }
    }
}
