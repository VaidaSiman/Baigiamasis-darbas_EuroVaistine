using EuroVaistineFramework;
using EuroVaistineFramework.Pages;
using EuroVaistineTests.BaseTests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace EuroVaistineTests.EuroVaistineScenarios
{
    internal class LogIn : BaseTest 
    {
        [SetUp]
        public void Open()
        {
            EuroVaistineMainPage.Open();
        }

        [Test]
        public void LogInWithInvalidCredentials()
        {
            string email = "test@test.com";
            string slaptazodis = "test";
            string expectedResult = "Pašto adresas nerastas. Prašome įvesti teisingą el. pašto adresą";

            EuroVaistineShoppingCart.ClickOnAdvertButton();
            EuroVaistineShoppingCart.ClickOnSlapukai();
            EuroVaistineMainPage.ClickButtonPrisijungti();
            EuroVaistineMainPage.EnterElektroninisPastas(email);
            EuroVaistineMainPage.EnterSlaptazodis(slaptazodis);
            EuroVaistineMainPage.ClickButtonPrisijungtiZalias();
           
            string actualResult  = EuroVaistineMainPage.GetAlertMessage(); 

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
