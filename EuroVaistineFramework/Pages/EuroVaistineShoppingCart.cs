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
            return Common.GetItemsPrice(locator);
        }
    }
}
