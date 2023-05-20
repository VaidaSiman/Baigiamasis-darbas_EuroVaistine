using OpenQA.Selenium;

namespace EuroVaistineFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator) 
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetAlertText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetItemsPrice(string locator)
        {
            return GetElement(locator).Text;
        }
    }
}
