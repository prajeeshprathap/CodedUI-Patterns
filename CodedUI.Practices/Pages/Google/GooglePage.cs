using CodedUI.Practices.Pages.Nuget;

namespace CodedUI.Practices.Pages.Google
{
    public class GooglePage : BasePage<GoogleMap, GoogleValidator>
    {
        public GooglePage LookFor(string keyword)
        {
            Map.SearchBox().SetText(keyword);
            return this;
        }

        public GooglePage Search()
        {
            Map.SearchButton().Click();
            return this;
        }

        public GooglePage ValidateNugetSiteLinkInResults()
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
        public GooglePage ValidateNugetResultsLastItemAs1(string value)
        {
            Validator.AssertLinkWithTextExistsInNugetTable1(value);
            return this;
        }

        public GooglePage ValidateNugetResultsLastItemAs2(string value)
        {
            Validator.AssertLinkWithTextExistsInNugetTable2(value);
            return this;
        }

        public GooglePage ValidateNugetResultsLastItemAs3(string value)
        {
            Validator.AssertLinkWithTextExistsInNugetTable3(value);
            return this;
        }
    }
}
