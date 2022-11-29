using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Scenarios.Pages;

namespace Scenarios.Steps
{
    public class SearchJourney
    {
        // write the steps for your the product search journey here
        private readonly HomePage _homePage = new HomePage();

        [Step("Search for <text> products")]
        public void SearchFor(string text)
        {
            var searchPage = _homePage.SearchFor(text);
            searchPage.IsCorrectPage();
        }

        [Step("Search for: <table>")]
        public void SearchForProducts(Table table)
        {
            var rows = table.GetTableRows();
            foreach (var row in rows)
            {
                var searchPage = _homePage.SearchFor(row.GetCell("product"));
                searchPage.IsCorrectPage();
                _homePage.Open();
            }
        }
        
    }
}
