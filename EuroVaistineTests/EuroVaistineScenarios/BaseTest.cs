using EuroVaistineFramework;
using NUnit.Framework;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
