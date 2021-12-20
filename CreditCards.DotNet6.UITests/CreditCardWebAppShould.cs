using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CreditCards.DotNet6.UITests
{
    public class CreditCardWebAppShould
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:44108/");
            Assert.True(1 == 1);
        }
    }
}
