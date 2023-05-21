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
        /*
        [Test]
        public void AddingItemViaSearchBox()
        {
            string expectedResult = "9,38 €"; //reiks manau, pakeisti, nes pagal kain1 nes1mone ziureti, nes jei kaina pasikeis? 

            //EuroVaistineShoppingCart.ClickOnAdvertButton(); //cia riekia kazkaip suletinima padaryt 
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitaminas C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.MoveMouseToItemAndClick(); 
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            string actualResult = EuroVaistineShoppingCart.GetItemsPrice(); //cia reikia pakeisti, nes pagal kaina ne tiks lyginti, o jei kaina keisis? 

            Assert.AreEqual(expectedResult, actualResult);
        }
        /*
        [Test]
        public void AddingItemViaHamburgerMeniu()
        {
            string expectedResult = "1";
            
            //EuroVaistineShoppingCart.ClickOnAdvertButton(); //cia riekia kazkaip suletinima padaryt //del sito butinai pkalausti
            EuroVaistineShoppingCart.ClickHamburgerMeniu();
            EuroVaistineShoppingCart.ClickOnVitaminaiIrMaistoPapildai();
            EuroVaistineShoppingCart.ClickOnVitaminaiIrMineralai();
            EuroVaistineShoppingCart.ClickOnVitaminasC();
            EuroVaistineShoppingCart.CllickPrekiuForma(); 
            EuroVaistineShoppingCart.ClickBatonelis();
            EuroVaistineShoppingCart.ClickButtonTaikyti();
            EuroVaistineShoppingCart.MoveMouseToItemAndClick(); //cia reikia paklausti, kaip pele nuvaryti iki ???? arr
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            
            string actualResult = EuroVaistineShoppingCart.GetNumberOfItemsInTheCart();

            Assert.AreEqual(expectedResult, actualResult);
        } 
        
        [Test]
        public void RemovingItemFromShoppingCart()
        {
            string expectedResult = "Jūsų krepšelis yra tuščias";
            
            EuroVaistineShoppingCart.ClickOnAdvertButton(); //cia riekia kazkaip suletinima padaryt 
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitaminas C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.MoveMouseToItemAndClick();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            EuroVaistineShoppingCart.CllickOnItemRemovalButton();
            
            string actualResult = EuroVaistineShoppingCart.GetMessageCartEmpty(); 

            Assert.AreEqual(expectedResult, actualResult);
        }
        */
        [Test]
        public void DeliveryAaddressSelection()
        {
            string expectedResult = "Antakalnio g. 59";

            EuroVaistineShoppingCart.ClickOnAdvertButton(); //cia riekia kazkaip suletinima padaryt 
            EuroVaistineShoppingCart.EnterItemsNameInSearchBox("Vitamina C PROLONG, 40 kapsulių");
            EuroVaistineShoppingCart.ClickSearchButton();
            EuroVaistineShoppingCart.MoveMouseToItemAndClick();
            EuroVaistineShoppingCart.ClickButtonIKrepseli();
            EuroVaistineShoppingCart.ClickOnShoppingCartIcon();
            EuroVaistineShoppingCart.ClickOnDeliveryOptionVaistineje();
            EuroVaistineShoppingCart.ClickOnListOptionPasirinktiVaistine(); //cia reiketu isskleisti sarasa, kazkur jis rode
            EuroVaistineShoppingCart.ClickOnAddressOptionAntakalnioG59(); // ar cia galima nera6yti skaiciu? 

            string actualResult = EuroVaistineShoppingCart.GetAddress(); //cia kas bus actual value pasitikrinti 

            Assert.AreEqual(expectedResult, actualResult); 
        }
       
        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
