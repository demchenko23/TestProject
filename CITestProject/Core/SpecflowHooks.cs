using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.Core
{
    [Binding]
    public class SpecflowHooks
    {
        private ScenarioContext scenarioContext;
        private FeatureContext featureContext;

        public SpecflowHooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            this.scenarioContext = scenarioContext;
            this.featureContext = featureContext;
        }

        [BeforeFeature]
        public static void OneTime(FeatureContext featureContext)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            featureContext.Set<IWebDriver>(driver);
        }

        [AfterFeature]
        public static void FeatureTearDown(FeatureContext featureContext)
        {
            featureContext.Get<IWebDriver>().Close();
            featureContext.Get<IWebDriver>().Dispose();
        }
    }
}
