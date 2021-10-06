using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.PageObjects
{
    public class GitHubPage
    {
        private IWebDriver driver { get; set; }
        public GitHubPage(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
        }
        public string URL = "https://github.com/";
        public IWebElement SignInLink => driver.FindElement(SignInLinkBy);
        public By SignInLinkBy => By.XPath("//a[@href='/login']");
    }
}
