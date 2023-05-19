using EuroVaistineFramework;
using EuroVaistineFramework.Pages;
using NUnit.Framework;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class LogInWithInvalidCredentilas
    {
        [Test]
        public void EuroVaistineSingleInputField()
        {
            string expectedResult = "Pašto adresas nerastas. Prašome įvesti teisingą el. pašto adresą";

            Driver.InitializeDriver();
            EuroVaistineMainPage.Open();

            EuroVaistineMainPage.ClickButtonPrisijungti();
            EuroVaistineMainPage.EnterElektroninisPastas("test@test.com");
            EuroVaistineMainPage.EnterSlaptazodis("test");
            EuroVaistineMainPage.ClickButtonPrisijungtiZalias();
            string actualResult  = EuroVaistineMainPage.GetAlertMessage(); 

            Assert.AreEqual(expectedResult, actualResult);
            Driver.ShutdownDriver();
        }
    }
}
