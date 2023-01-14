using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework
{
    internal class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static void ClearInputElement(string locator)
        {
            GetElement(locator).Clear();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void MovetoElement(string locator)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.MoveToElement(element);
            actions.Perform();
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void WaitForSeconds()
        {
            System.Threading.Thread.Sleep(3000);
        }

        internal static void AcceptAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Accept();
        }

        internal static string GetAlertText()
        {
            return Driver.GetDriver().SwitchTo().Alert().Text;
        }
    }
}
