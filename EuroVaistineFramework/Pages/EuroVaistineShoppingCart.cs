using OpenQA.Selenium.Interactions;
using System;
using System.Xml.Linq;

namespace EuroVaistineFramework.Pages
{
    public class EuroVaistineShoppingCart
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.eurovaistine.lt/");
        }

        public static void EnterItemsNameInSearchBox(string v)
        {
            //string locator = "//*[@id='editing-view-port']/div/";
            string locator = "//*[@class='sn-suggest-input headerSearchInput tt-input']";
            Common.SendKeys(locator, v);
        }

        public static void ClickSearchButton()
        {
            string locator = "//*[@class='headerSearchButton']";
            Common.Click(locator);
        }

        public static void ClickButtonIKrepseli()
        {
            string locator = "(//*[@class='product-btn'])[1]/button";
            Common.Click(locator);
        }

        public static string GetItemsPrice()
        {
            //string locator = "//*[@id='cart-block']/div/div[2]";
            string locator = "//*[@id='cart-block']/div/div[2]/text()";
            return Common.GetElementText(locator);
        }

        public static void ClickHamburgerMeniu()
        {
            string locator = "//*[@class='mainHorizontalMenuBurgerIcon'] ";
            Common.Click(locator);
        }

        public static void ClickOnVitaminaiIrMaistoPapildai()
        {
            string locator = "//*[@class='mainVerticalMenu']/div[3]/a";
            Common.Click(locator);
        }

        public static void ClickOnVitaminaiIrMineralai()
        {
            string locator = "//*[@class='categoryTag primary']/div";
            Common.Click(locator);
        }

        public static void ClickOnVitaminasC()
        {
            string locator = "(//*[@class='tagTitle'])[1]";
            Common.Click(locator);
        }

        public static void CllickPrekiuForma()
        {
            string locator = "(//*[@class='filterButton'])[6]";
            Common.Click(locator);
        }

        public static void ClickBatonelis()
        {
            string locator = "(//*[@class='filterDropdownChildrenContainer'])[6]/div[1]/div";
            Common.Click(locator);
        }

        public static void ClickButtonTaikyti()
        {
            string locator = "(//*[@class='filterDropdownSubmitBtn'])[6]";
            Common.ScrollUntillButtonIsClickable(locator);
        }

        public static string GetNumberOfItemsInTheCart()
        {
            string locator = "//*[@class='headerCart-amountWrapper']/div";
            return Common.GetElementText(locator);
        }

        public static void ClickOnShoppingCartIcon()
        {
            string locator = "//*[@class='headerCart-amountWrapper']";
            Common.Click(locator);
        }

        public static void CllickOnItemRemovalButton()
        {
            string locator = "//*[@class='productQuantityPriceContainer']/div[4]";
            Common.Click(locator);
        }

        public static string GetMessageCartEmpty()
        {
            //string locator = "//*[@class='text-center emptyCartTextBlock']/h3/text()";
            string locator = "//*[@class='text-center emptyCartTextBlock']";
            return Common.GetElementText(locator);
        }

        public static void ClickOnDeliveryOptionVaistineje()
        {
            string locator = "//*[@id='cart_shipments_0_method_0']";
            Common.Click(locator);
        }

        public static void ClickOnListOptionPasirinktiVaistine()
        {
            string locator = "(//*[@class='select2-selection__arrow']/b)[2]";
            Common.Click(locator);
        }

        public static void ClickOnAddressOptionAntakalnioG59()
        {
            string locator = "(//*[@class='select2-results__options']/li)[2]/div/label/input";
            Common.Click(locator);
        }

        public static string GetAddress()
        {
            string locator = "(//*[@class='select2-selection__rendered'])[2]/text()";
            return Common.GetElementText(locator);
        }

        public static void ClickOnAdvertButton()
        {
            string locatorSlapukai = " //*[@id='onetrust-accept-btn-handler']";
            string locator = "//*[@id=\"omnisend-form-64105ed1b09e89c71966c0dd-close-button\"]";

            Common.WaitForElementToBeVisisble(locatorSlapukai);
            Common.Click(locatorSlapukai);
            //System.Threading.Thread.Sleep(8000);  ///galimai reiks pakeisti 
            Common.WaitForElementToBeVisisble(locator);
            Common.Click(locator);
        }

        public static void MoveMouseToItemAndClick()
        {
            string locator = "(//*[@class='productCard'])[1]";

            Common.HoverOverElement(locator);
            Common.Click("(//*[contains(@class,'productCard')])[1]//*[contains(@class,'evBtnPrimary')]");
            //Common.Click(locator); // ?ar cia jo reikia? 
            //cia reikia veiksmo, gal Actions ? 
        }
    }
}
