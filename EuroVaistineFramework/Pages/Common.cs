using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EuroVaistineFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator) 
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
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

        internal static void WaitForElementToBeVisisble(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(20)); 
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Displayed);
        }

        internal static string GetElementAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static List <string> GetElementsTextList(string locator)
        {
            List<string> texts = new List<string>();

            List<IWebElement> elements = Common.GetElements(locator);
            foreach (IWebElement element in elements)
            {
                texts.Add(element.Text);
            }

            return texts;
        }
    }
}
