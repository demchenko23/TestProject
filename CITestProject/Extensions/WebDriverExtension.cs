using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CITestProject.Extensions
{
    public static class WebDriverExtension
    {
        public static bool IsElementVisible(this IWebDriver driver, By element)
        {
            bool result;
            try
            {
                driver.FindElement(element);
                result = true;
            }
            catch (NoSuchElementException)
            {
                result = false;
            }
            return result;
        }
    }
}
