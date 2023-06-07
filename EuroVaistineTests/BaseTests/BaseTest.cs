using EuroVaistineFramework;
using EuroVaistineFramework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace EuroVaistineTests.BaseTests
{
    internal class BaseTest 
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            HomePage.Open();
            ShoppingCart.ClickOnAdvertButton();
            ShoppingCart.ClickOnSlapukai();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }

            Driver.ShutdownDriver();
        }
    }
}
