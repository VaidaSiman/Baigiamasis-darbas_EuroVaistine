namespace EuroVaistineFramework.Pages
{
    public class EuroVaistineMainPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.eurovaistine.lt/");
        }

        public static void ClickButtonPrisijungti()
        {
            string locatorButtonPrisijungti = "//*[@class='headerUserMenuWrapper']"; 
            Common.Click(locatorButtonPrisijungti);
        }

        public static void EnterElektroninisPastas(string email)
        {
            string locator = "//*[@id='_username']";
            Common.SendKeys(locator, email);
        }

        public static void EnterSlaptazodis(string slaptazodis)
        {
            string locator = "//*[@id='_password']";
            Common.SendKeys(locator, slaptazodis);
        }

        public static void ClickButtonPrisijungtiZalias()
        {
            string locator = "//*[@class='form_name_shop_login_check default-form clearfix']/button";
            Common.Click(locator);
        }

        public static string GetAlertMessage()
        {
            string locator = "//*[@class='alert alert-danger']/text()";
            return Common.GetAlertText(locator);
        }
    }
}
