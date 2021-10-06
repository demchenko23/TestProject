using CITestProject.Extensions;
using CITestProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CITestProject.StepsImplementation
{
    [Binding]
    public class GitHubSteps
    {
        private IWebDriver driver { get; set; }
        public GitHubPage startPage { get; set; }
        public GitHubLoginPage loginPage { get; set; }
        public GitHubMainPage mainPage { get; set; }
        public GitHubSteps(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
            startPage = new GitHubPage(featureContext);
            loginPage = new GitHubLoginPage(featureContext);
            mainPage = new GitHubMainPage(featureContext);
        }
        [When(@"I navigate to GitHub page")]
        public void WhenINavigateToGitHubPage()
        {
            driver.Url = startPage.URL;
            driver.Manage().Window.Maximize();
        }

        [Then(@"GitHub page is displayed")]
        public void ThenGitHubPageIsDisplayed()
        {
            Assert.IsTrue(startPage.SignInLink.Displayed, "GitHub page is NOT displayed");
        }

        [When(@"I click on Sign In link")]
        public void WhenIClickOnSignInLink()
        {
            startPage.SignInLink.Click();
        }

        [Then(@"Login page is displayed")]
        public void ThenLoginPageIsDisplayed()
        {
            Assert.IsTrue(loginPage.UsernameOrEmailAddressTextBox.Displayed, "Login page is NOT displayed");
        }

        [When(@"I fill in Username field as '(.*)'")]
        public void WhenIFillInUsernameFieldAs(string username)
        {
            loginPage.UsernameOrEmailAddressTextBox.SendKeys(username);
        }

        [When(@"I fill in Password field as '(.*)'")]
        public void WhenIFillInPasswordFieldAs(string password)
        {
            loginPage.PasswordTextBox.SendKeys(password);
        }

        [When(@"I click on Sign In button")]
        public void WhenIClickOnSignInButton()
        {
            loginPage.SignInButton.Click();
        }

        [Then(@"Main page is displayed")]
        public void ThenMainPageIsDisplayed()
        {
            Assert.IsTrue(driver.IsElementVisible(mainPage.MainFormBy), "Main page is NOT displayed");
        }
    }
}
