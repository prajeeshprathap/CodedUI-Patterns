using System.Collections;
using System.Linq;
using CodedUI.Practices.Pages;
using CodedUI.Practices.Pages.Bing;
using CodedUI.Practices.Pages.Google;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUI.Practices
{
    [CodedUITest]
    public class Demo2Fixture
    {
        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }

        [TestMethod]
        [TestCategory("DemoCategory2")]
        public void Google_TestPerformanceSample1()
        {
            PageFactory
                .Create<GooglePage, GoogleMap, GoogleValidator>("http://www.google.com", false)
                .LookFor("nuget")
                .Search()
                .ValidateNugetResultsLastItemAs1("Hosting Your Own NuGet Feeds");
        }

        [TestMethod]
        [TestCategory("DemoCategory2")]
        public void Google_TestPerformanceSample2()
        {
            PageFactory
                .Create<GooglePage, GoogleMap, GoogleValidator>("http://www.google.com", false)
                .LookFor("nuget")
                .Search()
                .ValidateNugetResultsLastItemAs2("Hosting Your Own NuGet Feeds");
        }

        [TestMethod]
        [TestCategory("DemoCategory2")]
        public void Google_TestPerformanceSample3()
        {
            PageFactory
                .Create<GooglePage, GoogleMap, GoogleValidator>("http://www.google.com", false)
                .LookFor("nuget")
                .Search()
                .ValidateNugetResultsLastItemAs3("Hosting Your Own NuGet Feeds");
        }
    }
}
