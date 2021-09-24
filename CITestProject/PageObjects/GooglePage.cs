using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CITestProject.PageObjects
{
    public class GooglePage 
    {
        private IWebDriver driver;
        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string URL = "https://www.google.com/";
        public By InputTextBoxBy => By.XPath("//input[@class='gLFyf gsfi']");
        public IWebElement InputTextBox => driver.FindElement(InputTextBoxBy);
        public IWebElement ResultPage => driver.FindElement(By.XPath("//div[@class='GyAeWb']"));
    }
}
