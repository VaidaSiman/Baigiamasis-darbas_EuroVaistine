﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System;

namespace EuroVaistineFramework
{
    public class Driver
    {
        private static IWebDriver driver; 

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

       public static string TakeScreenshot(string methodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}screenshot.png";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}", ScreenshotImageFormat.Png);

            return screenshotFilePath;
        } 
    }
}
