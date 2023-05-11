using System;

namespace EuroVaistineFramework.Pages
{
    public class EuroVaistineMainPage
    {

        public static void Open()
        {
            Driver.OpenPage("https://www.eurovaistine.lt/");
        }

        public static void EnterMessage(string message) //pagal metodą pavadinimas
        {
            /*Byte locatorXpath = By.XPath(""); // kitas būdas, kaip be stringo pasirašyt */  //bet ji priklauso nuo Selenium, tai geriau nenaudoti taip, nes išmeta usingą priklausomą nuo selenium
            string locator = ""; // čia bus Xpath 
            Common.SendKeys(locator, message); // mūsų sukurtas send keys / metodas perduoda message ir elemento adresas (parametras) Locator Xpath/ negrąžina nieko
        }

        public static void ClickShowMessage()
        {
            string locator = ""; // Xpath čia vėl bus
            Common.Click(locator); //paspausime ant elemento / adresas elemento ant kurio spausime locator šiuo atveju / 
        }

        public static string GetYourmessage() //metodas grąžina atgal į testą
        {
            string locator = "";
            return Common.GetElementText(locator); //perduodam locator ir gaunam tekstą , bus lyginamas šitas gaunamas elementas, bet kitoj vietoje, ne čia tai kintamojo kurti nereikia
        }
    }
}
