using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.WebAudio;
using OpenQA.Selenium.Support.Extensions;
using System;

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

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ScrollUntillButtonIsClickable(string locator)
        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = 20;
            int currentTry = 0;

            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }

                catch(Exception e)
                {
                    if(e is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0, 10)");
                        currentTry++;
                    }
                    else
                    {
                        throw e;
                    }
                }
            }
        }
    }
}
