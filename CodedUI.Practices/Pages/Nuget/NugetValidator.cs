using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUI.Practices.Pages.Nuget
{
    public class NugetValidator : BaseValidator<NugetMap>
    {
        public void AssertNugetLogoOnSite()
        {
            Assert.IsTrue(Map.LogoDiv().Exists, "Expected a logo on the website");
        }
    }
}
