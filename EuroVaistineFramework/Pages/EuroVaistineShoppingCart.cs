namespace EuroVaistineFramework.Pages
{
    public class EuroVaistineShoppingCart
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.eurovaistine.lt/");
        }

        public static void ClickOnAdvertButton()
        {
            string locator = "//*[@id='omnisend-form-64105ed1b09e89c71966c0dd-close-icon']/path";
            Common.Click(locator);
        }

        public static void EnterItemsNameInSearchBox(string v)
        {
            string locator = "//*[@id='editing-view-port']/div/";
            Common.SendKeys(locator, v);
        }

        public static void ClickSearchButton()
        {
            string locator = " //*[@id='search-block']/div/button/svg";
            Common.Click(locator);
        }

        public static void ClickButtonIKrepseli()
        {
            string locator = "//*[@class='evBtn evBtnPrimary']/span";
            Common.Click(locator);
        }

        public static string GetItemsPrice()
        {
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
            string locator = "//*[@class='categoryTag primary']/div/text()";
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
            string locator = "(//*[@class='filterListLabel'])[106]";
            Common.Click(locator);
        }

        public static void ClickButtonTaikyti()
        {
            string locator = "(//*[@class='filterDropdownSubmitBtn'])[6]";
            Common.Click(locator);
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
            string locator = "//*[@class='productQuantityPriceContainer']/div[4]/a";
            Common.Click(locator);
        }

        public static string GetMessageCartEmpty()
        {
            string locator = "//*[@class='text-center emptyCartTextBlock']/h3/text()";
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
    }
}
