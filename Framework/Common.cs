using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;

namespace Framework
{
    internal class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
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

        internal static void WaitForSeconds()
        {
            System.Threading.Thread.Sleep(3000);
        }
    }
}
