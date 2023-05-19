using EuroVaistineFramework;
using EuroVaistineFramework.Pages;
using NUnit.Framework;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class ScenarioFirstTest
    {
        [Test]
        public void EuroVaistineSingleInputField()
        {
            string expectedResult = "Vaida";

            Driver.InitializeDriver();
            EuroVaistineMainPage.Open();

            EuroVaistineMainPage.EnterMessage(expectedResult); // čia buvo iš to Demo, kur ENTER MESSAGE laukelis, taip ir pavadinome, pas mane baigiamajame bus kitaip
            EuroVaistineMainPage.ClickShowMessage(); //cia buvo iš demo.seleniumeasy.com, kur showmessage mygtukas buvo, pas mane bus kitaip 
            string actualResult  = EuroVaistineMainPage.GetYourmessage(); //cia buvo is demo.selenium.com, kur yourmessage laukelis yra; // norim gauti, bet nikeo neperduodam nuskaito teksta, kuris grazinamas atgal i koda
            
            string actualResult = textYourMessage.Text; 

            Assert.AreEqual(expectedResult, actualResult);
            Driver.ShutdownDriver();
        }
    }
}
