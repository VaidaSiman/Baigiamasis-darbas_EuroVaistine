using EuroVaistineFramework.Pages;
using NUnit.Framework;
using EuroVaistineTests.BaseTests;

namespace EuroVaistineTests.TestCases
{
    internal class ActionsWithShoppingCart : BaseTest 
    {
        [Test]
        public void AddingItemViaSearchBox()
        {
            string expectedResult = "1";

            ShoppingCart.EnterItemsNameInSearchBox("Vitaminas C PROLONG, 40 kapsulių");
            ShoppingCart.ClickSearchButton();
            ShoppingCart.ClickOnItemVitaminasCProlong();
            ShoppingCart.ClickButtonIKrepseli();
            ShoppingCart.ClickOnShoppingCartIcon();
            string actualResult = ShoppingCart.GetNumberOfItemsInTheCart(); 

            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void AddingItemViaHamburgerMeniu()
        {
            string expectedResult = "1";
            
            ShoppingCart.ClickHamburgerMeniu();
            ShoppingCart.ClickOnVitaminaiIrMaistoPapildai();
            ShoppingCart.ClickOnVitaminaiIrMineralai();
            ShoppingCart.ClickOnVitaminasC();
            ShoppingCart.CllickPrekiuForma(); 
            ShoppingCart.ClickBatonelis();
            ShoppingCart.ClickButtonTaikyti();
            ShoppingCart.ClickOnItemHematogenas();
            ShoppingCart.ClickButtonIKrepseli();
            ShoppingCart.ClickOnShoppingCartIcon();
            string actualResult = ShoppingCart.GetNumberOfItemsInTheCart();

            Assert.AreEqual(expectedResult, actualResult);
        } 
        
        [Test]
        public void RemovingItemFromShoppingCart()
        {
            string expectedResult = "Jūsų krepšelis yra tuščias";

            ShoppingCart.EnterItemsNameInSearchBox("Vitaminas C PROLONG, 40 kapsulių");
            ShoppingCart.ClickSearchButton();
            ShoppingCart.ClickOnItemVitaminasCProlong();
            ShoppingCart.ClickButtonIKrepseli();
            ShoppingCart.ClickOnShoppingCartIcon();
            ShoppingCart.CllickOnItemRemovalButton();
            string actualResult = ShoppingCart.GetMessageCartEmpty(); 

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
