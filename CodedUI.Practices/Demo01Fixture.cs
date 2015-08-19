using System.Diagnostics;
using CodedUI.Practices.Pages;
using CodedUI.Practices.Pages.Bing;
using CodedUI.Practices.Pages.Google;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUI.Practices
{
    [CodedUITest]
    public class Demo01Fixture
    {
        private static Process _windowProcess; 
        private TestContext _testContext;
        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }


        [ClassInitialize]
        public static void MyClassInitialize(TestContext context)
        {
            //Every control in the hierarchy will be searched in order.
            //Any failure will result in test failure
            Playback.PlaybackSettings.MatchExactHierarchy = true;
        }

        [TestInitialize]
        public void TestInitialize()
        {
            
        }

        [TestMethod]
        [TestCategory("DemoCategory1")]
        public void Google_SearchForNugetSite()
        {
            var google = PageFactory
                .Create<GooglePage, GoogleMap, GoogleValidator>("http://www.google.com", false);
            _windowProcess = google.WindowProcess;
            google.LookFor("nuget")
                .Search()
                .ValidateNugetSiteLinkInResults();

        }

        [TestMethod]
        [TestCategory("DemoCategory1")]
        public void Nuget_SearchPackageOnNugetTest()
        {
            var google = PageFactory.Create<GooglePage, GoogleMap, GoogleValidator>(_windowProcess);

            google.VisitNugetSite()
                .VerifyNugetSiteLoaded();
        }

        [ClassCleanup]
        public static void MyClassCleanup()
        {
            var window = BrowserWindow.FromProcess(_windowProcess);
            window.Close();
        }
    }
}