using CITestProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CITestProject.StepsImplementation
{
    [Binding]
    public class GoogleSteps
    {
        private IWebDriver driver { get; set; }
        public GooglePage page { get; set; }
        public GoogleSteps(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
            page = new GooglePage(featureContext);
        }

        [When(@"I navigate to Google page")]
        public void WhenINavigateToGooglePage()
        {
            driver.Url = page.URL;
        }

        [Then(@"Google page is displayed")]
        public void ThenGooglePageIsDisplayed()
        {
            Assert.IsTrue(page.InputTextBox.Displayed, "Google page is NOT opened");
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

        [Then(@"Result page is displayed")]
        public void ThenResultPageIsDisplayed()
        {
            Assert.IsTrue(page.ResultPage.Displayed, "Result page is NOT opened");
        }
    }
}
