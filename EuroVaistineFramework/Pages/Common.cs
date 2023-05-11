using OpenQA.Selenium;
using System;

namespace EuroVaistineFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator) //grąžiną patį elementą, turi likti pricate
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            /*Driver.GetDriver().FindElement(By.XPath(locator)).Click(); //čia gali taip būti, bet tai dubliuojasi visuose metoduose, tai supaprastiname */
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            /*IWebElement element = Driver.GetDriver().FindElement(By.XPath(locator)); // element, nes gali būti viskas, bet kokioj svetainėj / išsaugota reikšmė 
            element.SendKeys(keys); */

           //Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(keys); 
           GetElement(locator).SendKeys(keys);
        }
    }
}
