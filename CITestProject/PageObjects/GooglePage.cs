using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.PageObjects
{
    public class GooglePage 
    {
        private IWebDriver driver { get; set; }
        public GooglePage(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
        }
        public string URL = "https://www.google.com/";
        public By InputTextBoxBy => By.XPath("//input[@class='gLFyf gsfi']");
        public IWebElement InputTextBox => driver.FindElement(InputTextBoxBy);
        public IWebElement ResultPage => driver.FindElement(By.XPath("//div[@class='GyAeWb']"));
    }
}
