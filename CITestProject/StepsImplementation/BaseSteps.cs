using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CITestProject.StepsImplementation
{
    [Binding]
    public class BaseSteps 
    {
        private IWebDriver driver { get; set; }
        public BaseSteps(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
        }
    }
}
