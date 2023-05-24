using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System.IO;
using System;
using System.Net.NetworkInformation;

namespace EuroVaistineFramework
{
    public class Driver
    {
        private static IWebDriver driver; 

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            //ChromeOptions options = new ChromeOptions(); ///????
            //driver.Value = new ChromeDriver(options); //????
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

       public static void TakeScreenshot()
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{Guid.NewGuid()} - screenshots";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\scr-{screenshotName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.png";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}.png", ScreenshotImageFormat.Png);
        } 
    }
}
