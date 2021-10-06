using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.PageObjects
{
    public class GitHubMainPage
    {
        private IWebDriver driver { get; set; }
        public GitHubMainPage(FeatureContext featureContext)
        {
            driver = featureContext.Get<IWebDriver>();
        }
        public By MainFormBy => By.XPath("//body[@class='logged-in env-production page-responsive full-width']");
    }
}
