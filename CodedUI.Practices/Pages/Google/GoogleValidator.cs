using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUI.Practices.Pages.Google
{
    public class GoogleValidator : BaseValidator<GoogleMap>
    {
        public void AssertNugetSiteInSearchResults()
        {
            Assert.IsTrue(Map.NugetSiteLink().Exists, "Expected a Google logo on the page");
        }

        public void AssertLinkWithTextExistsInNugetTable1(string value)
        {
            Assert.IsTrue(Map.NugetSubLink1(value).Exists, String.Format("Expected a link with text {0} on page", value));
        }

        public void AssertLinkWithTextExistsInNugetTable2(string value)
        {
            Assert.IsTrue(Map.NugetSubLink2(value).Exists, String.Format("Expected a link with text {0} on page", value));
        }

        public void AssertLinkWithTextExistsInNugetTable3(string value)
        {
            Assert.IsTrue(Map.NugetSubLink3(value).Exists, String.Format("Expected a link with text {0} on page", value));
        }
    }
}