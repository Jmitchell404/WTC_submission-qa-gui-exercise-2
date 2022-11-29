using FluentAssertions;
using OpenQA.Selenium;
using static Scenarios.GaugeSupport;

namespace Scenarios.Pages
{
    public class HomePage
    {
        // create a page object for the home page
        private const string Url = "http://localhost:90"; 
        private static readonly IWebDriver Driver = GaugeSupport.Driver;
        private static IWebElement SearchField => Driver.FindElement(By.XPath("/html/body/div[6]/div[1]/div[2]/div[2]/form/input"));
        private static IWebElement SearchButton => Driver.FindElement(By.XPath("/html/body/div[6]/div[1]/div[2]/div[2]/form/button"));


        public HomePage Open()
        {
            Driver.Navigate().GoToUrl(Url);
            Driver.Title.Should().Be("Your store. Home page title");
            return this;
        }

        public SearchPage SearchFor(string text)
        {
            SearchField.SendKeys(text);
            SearchButton.Click();
            return new SearchPage(text);
        }

    }
}
