using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EuroVaistineFramework
{
    public class Driver
    {
        private static IWebDriver driver; //galima kreiptis tik per metodą GetDriver, nes privatus padarytas 

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Quit();
        }
    }
}
