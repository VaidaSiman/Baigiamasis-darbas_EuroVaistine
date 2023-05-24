using EuroVaistineFramework.Pages;
using NUnit.Framework;
using EuroVaistineTests.BaseTests;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class ActionsWithShoppingCart : BaseTest 
    {
        [SetUp]
        public void Open()
        {
            EuroVaistineMainPage.Open();
        }
        
        [Test]
        public void AddingItemViaSearchBox()
        {
            string expectedResult = "1";

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.ClickOnSlapukai();
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitaminas C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickOnItemVitaminasCProlong();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            string actualResult = EuroVaistineShoppingCart.GetNumberOfItemsInTheCart(); 

            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void AddingItemViaHamburgerMeniu()
        {
            string expectedResult = "1";
            
            EuroVaistineShoppingCart.ClickOnAdvertButton(); 
            EuroVaistineShoppingCart.ClickOnSlapukai();
            EuroVaistineShoppingCart.ClickHamburgerMeniu();
            EuroVaistineShoppingCart.ClickOnVitaminaiIrMaistoPapildai();
            EuroVaistineShoppingCart.ClickOnVitaminaiIrMineralai();
            EuroVaistineShoppingCart.ClickOnVitaminasC();
            EuroVaistineShoppingCart.CllickPrekiuForma(); 
            EuroVaistineShoppingCart.ClickBatonelis();
            EuroVaistineShoppingCart.ClickButtonTaikyti();
            EuroVaistineShoppingCart.ClickOnItemHematogenas();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();

            string actualResult = EuroVaistineShoppingCart.GetNumberOfItemsInTheCart();

            Assert.AreEqual(expectedResult, actualResult);
        } 
        
        [Test]
        public void RemovingItemFromShoppingCart()
        {
            string expectedResult = "Jūsų krepšelis yra tuščias";

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.ClickOnSlapukai();
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitaminas C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickOnItemVitaminasCProlong();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            EuroVaistineShoppingCart.CllickOnItemRemovalButton();
            
            string actualResult = EuroVaistineShoppingCart.GetMessageCartEmpty(); 

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
