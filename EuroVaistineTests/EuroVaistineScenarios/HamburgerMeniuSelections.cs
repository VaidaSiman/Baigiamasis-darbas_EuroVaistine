using EuroVaistineFramework.Pages;
using EuroVaistineTests.BaseTests;
using NUnit.Framework;
using System.Collections.Generic;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class HamburgerMeniuSelections : BaseTest
    {
        [SetUp]
        public void Open()
        {
            EuroVaistineMainPage.Open();
        }

        [Test]
        public void HamburgerMeniuSelection()
        {
            List<string> expectedValues = new List<string>() { "Akcijos", "Kosmetika", "Vitaminai ir maisto papildai", "Vaistai nereceptiniai", "Medicinos ir slaugos prekės", "Higiena", "Vaikui ir mamai", "Sportas ir ortopedija", "Namai ir elektronika", "Vaistai skirti gydytojo", "Prekių ženklai" };

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.ClickOnSlapukai();
            EuroVaistineShoppingCart.ClickHamburgerMeniu();

            Assert.IsTrue(EuroVaistineShoppingCart.CheckIfActualValuesContainsAllOfTheEcpectedValues(expectedValues));
        }
    }
}
