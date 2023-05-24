using EuroVaistineFramework;
using EuroVaistineFramework.Pages;
using NUnit.Framework;
using EuroVaistineTests.BaseTests;
using NUnit.Framework.Interfaces;


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

            string actualResult = EuroVaistineShoppingCart.GetNumberOfItemsInTheCart(); //sita bandyt padaryt per pagrindini puslapisu tuo mazu skaiciuku

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
        
        [Test]
        public void DeliveryAaddressSelection()
        {
            string expectedResult = "Antakalnio g. 59";

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.ClickOnSlapukai();
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitamina C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickOnItemVitaminasCProlong();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            //EuroVaistineShoppingCart.CloseChatWindow(); //???
            EuroVaistineShoppingCart.ClickOnDeliveryOptionVaistineje();
            EuroVaistineShoppingCart.ClickOnListOptionPasirinktiVaistine(); 
            EuroVaistineShoppingCart.ClickOnAddressOptionAntakalnioG59(); 

            string actualResult = EuroVaistineShoppingCart.GetAddress(); //cia kas bus actual value pasitikrinti 

            Assert.AreEqual(expectedResult, actualResult); 
        } 
    }
}
