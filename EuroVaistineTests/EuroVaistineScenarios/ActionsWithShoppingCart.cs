using EuroVaistineFramework;
using EuroVaistineFramework.Pages;
using NUnit.Framework;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class ActionsWithShoppingCart
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            EuroVaistineMainPage.Open();
        }

        [Test]
        public void AddingItemViaSearchBox()
        {
            string expectedResult = "9,38 €";

            EuroVaistineShoppingCart.ClickOnAdvertButton(); //cia riekia kazkaip suletinima padaryt 
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitamina C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            string actualResult = EuroVaistineShoppingCart.GetItemsPrice();

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void AddingItemViaHamburgerMeniu()
        {
            string expectedResult = "1,34 €";

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
        }

        public void RemovingItemFromShoppingCart()
        {
            string expectedResult = "Jūsų krepšelis yra tuščias";

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitamina C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            EuroVaistineShoppingCart.CllickOnItemRemovalButton();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();

            string actualResult = EuroVaistineShoppingCart.GetItemsPrice(); //cia kas bus actual value pasitikrinti ar neturi b8ti getelement text labaiu, kaip benrinis visiems tinkamas?

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void DeliveryAaddressSelection()
        {
            string expectedResult = "Antakalnio g. 59";

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
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
