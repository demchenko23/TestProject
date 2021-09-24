using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.StepsImplementation
{
    [Binding]
    public class BaseSteps 
    {
        private IWebDriver driver;
        public BaseSteps(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
        }
    }
}
