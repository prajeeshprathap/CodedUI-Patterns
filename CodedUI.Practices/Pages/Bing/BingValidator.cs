using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUI.Practices.Pages.Bing
{
    public class BingValidator : BaseValidator<BingMap>
    {
        public void AssertNugetSiteInSearchResults()
        {
            Assert.IsTrue(Map.NugetSiteLink().Exists, "Expected a Google logo on the page");
        }
    }
}