using EuroVaistineFramework.Pages;
using EuroVaistineTests.BaseTests;
using NUnit.Framework;
using System.Collections.Generic;

namespace EuroVaistineTests.TestCases
{
    internal class HamburgerMeniuSelections : BaseTest
    {
        [SetUp]
        public void Open()
        {
            HomePage.Open();
        }

        [Test]
        public void HamburgerMeniuSelection()
        {
            List<string> expectedValues = new List<string>() { "Akcijos", "Kosmetika", "Vitaminai ir maisto papildai", "Vaistai nereceptiniai", "Medicinos ir slaugos prekės", "Higiena", "Vaikui ir mamai", "Sportas ir ortopedija", "Namai ir elektronika", "Vaistai skirti gydytojo", "Prekių ženklai" };

            ShoppingCart.ClickOnAdvertButton();
            ShoppingCart.ClickOnSlapukai();
            ShoppingCart.ClickHamburgerMeniu();

            Assert.IsTrue(ShoppingCart.CheckIfActualValuesContainsAllOfTheEcpectedValues(expectedValues));
        }
    }
}
