using EuroVaistineFramework.Pages;
using EuroVaistineTests.BaseTests;
using NUnit.Framework;

namespace EuroVaistineTests.TestCases
{
    internal class LogIn : BaseTest 
    {
        [Test]
        public void LogInWithInvalidCredentials()
        {
            string email = "test@test.com";
            string slaptazodis = "test";
            string expectedResult = "Pašto adresas nerastas. Prašome įvesti teisingą el. pašto adresą";

            ShoppingCart.ClickOnAdvertButton();
            ShoppingCart.ClickOnSlapukai();
            HomePage.ClickButtonPrisijungti();
            HomePage.EnterElektroninisPastas(email);
            HomePage.EnterSlaptazodis(slaptazodis);
            HomePage.ClickButtonPrisijungtiZalias();
           
            string actualResult  = HomePage.GetAlertMessage(); 

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
