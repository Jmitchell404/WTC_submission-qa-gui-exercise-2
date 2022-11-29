using Gauge.CSharp.Lib.Attribute;
using Scenarios.Pages;

namespace Scenarios.Steps
{
    public class HomePageJourney
    {
        // write the steps for your the storefront/homepage journey here
        private readonly HomePage _homePage = new HomePage();

        [Step("Navigate to the home page of NopCommerce")]
        public void OpenHomePage() => _homePage.Open();
    }
}
