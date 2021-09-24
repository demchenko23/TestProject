using CITestProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.StepsImplementation
{
    [Binding]
    public class GoogleSteps
    {
        private IWebDriver driver;
        private GooglePage page;
        public GoogleSteps(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
            page = new GooglePage(driver);
        }

        [When(@"I navigate to Google page")]
        public void WhenINavigateToGooglePage()
        {
            driver.Url = page.URL;
        }

        [Then(@"Google page is opened")]
        public void ThenGooglePageIsOpened()
        {
            Assert.IsTrue(page.InputTextBox.Displayed);
        }

        [When(@"I fill in query text '(.*)'")]
        public void WhenIFillInQueryText(string text)
        {
            page.InputTextBox.SendKeys(text);
        }

        [When(@"I Click Enter")]
        public void WhenIClickEnter()
        {
            page.InputTextBox.SendKeys(Keys.Enter);
        }

        [Then(@"Result page is opened")]
        public void ThenResultPageIsOpened()
        {
            Assert.IsTrue(page.ResultPage.Displayed);
        }
    }
}
