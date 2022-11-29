using System.Collections.ObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using static Scenarios.GaugeSupport;

namespace Scenarios.Pages
{
    public class SearchPage
    {
        // Create a page object for the search results page.
        private readonly string _text;

        public SearchPage(string text)
        {
            _text = text;
        }

        public SearchPage IsCorrectPage()
        {
            GaugeSupport.Driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/div[2]/div/div[2]/div[1]/form/div[1]/div/div[1]/div[1]/input")).GetAttribute("value").Should().Be(_text);
            return this;
        }

    }
}