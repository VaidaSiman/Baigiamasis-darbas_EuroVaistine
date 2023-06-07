using System;
using System.Collections.Generic;

namespace EuroVaistineFramework.Pages
{
    public class ShoppingCart
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.eurovaistine.lt/");
        }

        public static void EnterItemsNameInSearchBox(string v)
        {
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
            string locator = "//*[@id='cart_items_0_quantity']"; 
            return Common.GetElementAttributeValue(locator, "value");
        }

        public static void ClickOnShoppingCartIcon()
        {
            string locator = "//*[@class='headerCart-amountWrapper']";
            System.Threading.Thread.Sleep(2000);
            Common.Click(locator);
        }

        public static void CllickOnItemRemovalButton()
        {
            string locator = "//*[@class='productQuantityPriceContainer']/div[4]";
            Common.Click(locator);
        }

        public static string GetMessageCartEmpty()
        {
            string locator = "//*[@class='text-center emptyCartTextBlock']/h3";
            return Common.GetElementText(locator);
        }

        public static void ClickOnDeliveryOptionVaistineje()
        {
            string locator = "(//*[@class='shipping-method--details-block-top'])[1]"; 
            Common.ScrollUntillButtonIsClickable(locator);
        }

        public static void ClickOnListOptionPasirinktiVaistine()
        {
            string locator = "//*[@id='select2-delivery-point-container']"; 
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
            string locator = "//*[@id='omnisend-form-64105ed1b09e89c71966c0dd-close-button']";
            Common.WaitForElementToBeVisisble(locator);
            Common.Click(locator);
        }

        public static void ClickOnSlapukai()
        {
            string locatorSlapukai = "//*[@id='onetrust-accept-btn-handler']";
            Common.WaitForElementToBeVisisble(locatorSlapukai);
            Common.Click(locatorSlapukai);
        }

        public static void ClickOnItemVitaminasCProlong()
        {
            string locator = "(//*[@class='productCard'])[1]";
            Common.Click(locator);
        }

        public static void ClickOnItemHematogenas()
        {
            string locator = "//*[@class='productCard']";
            Common.Click(locator);
        }

        public static bool CheckIfActualValuesContainsAllOfTheEcpectedValues(List<string> expectedValues)
        {
            string locator = "//*[@class='mainVerticalMenuItem']";
            List<string> actualValues = Common.GetElementsTextList(locator);

            foreach (string value in expectedValues)
            {
                if (!actualValues.Contains(value))
                {
                    return false;
                    throw new Exception($"Value '{value}' is not existing!");
                }
            }
            return true;
        }
    }
}
