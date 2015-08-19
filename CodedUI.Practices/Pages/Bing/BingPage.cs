using CodedUI.Practices.Pages.Nuget;

namespace CodedUI.Practices.Pages.Bing
{
    public class BingPage : BasePage<BingMap, BingValidator>
    {
        public BingPage LookFor(string keyword)
        {
            Map.SearchBox().SetText(keyword);
            return this;
        }

        public BingPage Search()
        {
            Map.SearchButton().Click();
            return this;
        }

        public BingPage ValidateNugetSiteLinkInResults()
        {
            Validator.AssertNugetSiteInSearchResults();
            return this;
        }

        public NugetPage VisitNugetSite()
        {
            var nugetLink = Map.NugetSiteLink();
            Map.Navigate(nugetLink.Href);
            return PageFactory.Create<NugetPage, NugetMap, NugetValidator>(WindowProcess);
        }

        public void ValidateNugetResultsLastItemAs(string value)
        {
            

        }
    }
}
