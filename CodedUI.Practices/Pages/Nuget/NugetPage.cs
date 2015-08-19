namespace CodedUI.Practices.Pages.Nuget
{
    public class NugetPage : BasePage<NugetMap, NugetValidator>
    {
        public NugetPage VerifyNugetSiteLoaded()
        {
            Validator.AssertNugetLogoOnSite();
            return this;
        }
    }
}
