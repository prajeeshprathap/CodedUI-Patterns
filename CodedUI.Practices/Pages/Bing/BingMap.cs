using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUI.Practices.Pages.Bing
{
    public class BingMap : BaseMap
    {
        public BingMap(BrowserWindow window) : base(window)
        {
        }

        internal HtmlDiv SearchBox()
        {
            var searchConditions = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Id, "sb_ifc0", PropertyExpressionOperator.EqualTo),
                new PropertyExpression(HtmlControl.PropertyNames.Class, "sbib_b", PropertyExpressionOperator.EqualTo)
            };
            return Window.Find<HtmlDiv>(searchConditions);
        }

        internal HtmlControl SearchButton()
        {
            var searchConditions = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Name, "btnG", PropertyExpressionOperator.EqualTo),
                new PropertyExpression(HtmlControl.PropertyNames.TagName, "button", PropertyExpressionOperator.EqualTo)
            };
            return Window.Find(searchConditions);
        }

        internal HtmlHyperlink NugetSiteLink()
        {
            var searchConditions = new PropertyExpressionCollection
            {
                new PropertyExpression("href", "https://www.nuget.org", PropertyExpressionOperator.Contains)
            };
            return Window.Find<HtmlHyperlink>(searchConditions);
        }
    }
}