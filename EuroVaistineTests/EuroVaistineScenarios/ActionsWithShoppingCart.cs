using EuroVaistineFramework;
using EuroVaistineFramework.Pages;
using NUnit.Framework;
using System.Net.NetworkInformation;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class ActionsWithShoppingCart
    {
        [Test]
        public void AddingItemViaSearchBox()
        {
            string expectedResult = "9,38 €";

            Driver.InitializeDriver(); //neturetu but teste
            EuroVaistineMainPage.Open(); //neturetu but teste, nes dubliuojasi

            EuroVaistineShoppingCart.ClickOnAdvertButton(); //cia riekia kazkaip suletinima padaryt 
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitamina C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            string actualResult = EuroVaistineShoppingCart.GetItemsPrice();

            Assert.AreEqual(expectedResult, actualResult);
            Driver.ShutdownDriver();
        }

        public void AddingItemViaHamburgerMeniu()
        {
            string expectedResult = "1,34 €";
            Driver.InitializeDriver();
            EuroVaistineMainPage.Open();

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.ClickHamburgerMeniu();
            EuroVaistineShoppingCart.ClickOnVitaminaiIrMaistoPapildai();
            EuroVaistineShoppingCart.ClickOnVitaminaiIrMineralai();
            EuroVaistineShoppingCart.ClickOnVitaminasC();
            EuroVaistineShoppingCart.CllickPrekiuForma(); //cia reiketu isskleisti sarasa, kazkur jis rode
            EuroVaistineShoppingCart.ClickBatonelis();
            EuroVaistineShoppingCart.ClickButtonTaikyti();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();

            string actualResult = EuroVaistineShoppingCart.GetItemsPrice();

            Assert.AreEqual(expectedResult, actualResult);
            Driver.ShutdownDriver();
        }

        public void RemovingItemFromShoppingCart()
        {
            string expectedResult = "Jūsų krepšelis yra tuščias";
            Driver.InitializeDriver();
            EuroVaistineMainPage.Open();

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitamina C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            EuroVaistineShoppingCart.CllickOnItemRemovalButton();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();

            string actualResult = EuroVaistineShoppingCart.GetItemsPrice(); //cia kas bus actual value pasitikrinti ar neturi b8ti getelement text labaiu, kaip benrinis visiems tinkamas?

            Assert.AreEqual(expectedResult, actualResult);
            Driver.ShutdownDriver();
        }

        public void DeliveryAaddressSelection()
        {
            string expectedResult = "Antakalnio g. 59";
            Driver.InitializeDriver();
            EuroVaistineMainPage.Open();

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitamina C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            EuroVaistineShoppingCart.ClickOnDeliveryOptionVaistineje();
            EuroVaistineShoppingCart.ClickOnListOptionPasirinktiVaistine(); //cia reiketu isskleisti sarasa, kazkur jis rode
            EuroVaistineShoppingCart.ClickOnAddressOptionAntakalnioG59(); // ar cia galima nera6yti skaiciu? 

            string actualResult = EuroVaistineShoppingCart.GetItemsPrice(); //cia kas bus actual value pasitikrinti 

            Assert.AreEqual(expectedResult, actualResult);
            Driver.ShutdownDriver();
        }
    }
}
