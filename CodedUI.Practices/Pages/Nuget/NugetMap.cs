using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUI.Practices.Pages.Nuget
{
    public class NugetMap : BaseMap
    {
        public NugetMap(BrowserWindow window) : base(window)
        {
        }

        public HtmlDiv LogoDiv()
        {
            var searchConditions = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Id, "logo", PropertyExpressionOperator.EqualTo)
            };
            return Window.Find<HtmlDiv>(searchConditions);
        }
    }
}
