using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.PageObjects
{
    public class GitHubLoginPage
    {
        private IWebDriver driver { get; set; }
        public GitHubLoginPage(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
        }
        public IWebElement UsernameOrEmailAddressTextBox => driver.FindElement(By.XPath("//input[@id='login_field']"));
        public IWebElement PasswordTextBox => driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement SignInButton => driver.FindElement(By.XPath("//input[@name='commit']"));
    }
}
