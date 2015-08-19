using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUI.Practices.Pages.Google
{
    public class GoogleMap : BaseMap
    {
        public GoogleMap(BrowserWindow window)
            : base(window)
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

        internal HtmlHyperlink NugetSubLink1(string innerText)
        {
            var searchConditions = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Class, "nrgt", PropertyExpressionOperator.EqualTo)
            };
            var nugetResultTable = Window.Find<HtmlTable>(searchConditions);

            foreach (HtmlRow row in nugetResultTable.Rows)
            {
                foreach (HtmlCell cell in row.Cells)
                {
                    var condition = new PropertyExpressionCollection
                    {
                        new PropertyExpression(HtmlControl.PropertyNames.Class, "l",
                            PropertyExpressionOperator.EqualTo),
                        new PropertyExpression(HtmlControl.PropertyNames.InnerText, innerText,
                            PropertyExpressionOperator.EqualTo)
                    };
                    var link = cell.Find<HtmlHyperlink>(condition);
                    if (link.Exists)
                    {
                        return link;
                    }
                }
            }
            return null;
        }

        internal HtmlHyperlink NugetSubLink2(string innerText)
        {
            var searchConditions = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Class, "nrgt", PropertyExpressionOperator.EqualTo)
            };
            var nugetResultTable = Window.Find<HtmlTable>(searchConditions);
            var condition = new PropertyExpressionCollection
                    {
                        new PropertyExpression(HtmlControl.PropertyNames.Class, "l",
                            PropertyExpressionOperator.EqualTo),
                        new PropertyExpression(HtmlControl.PropertyNames.InnerText, innerText,
                            PropertyExpressionOperator.EqualTo)
                    };
            return nugetResultTable.Find<HtmlHyperlink>(condition);
        }

        internal HtmlHyperlink NugetSubLink3(string innerText)
        {
            var bigDivSearch = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Id, "cnt", PropertyExpressionOperator.EqualTo),
                new PropertyExpression(HtmlControl.PropertyNames.Class, "big", PropertyExpressionOperator.EqualTo)
            };
            var bigDiv = Window.Find<HtmlDiv>(bigDivSearch);
            var resultsDivSearch = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Class, "mw", PropertyExpressionOperator.EqualTo)
            };
            var resultsDiv = bigDiv.Find<HtmlDiv>(resultsDivSearch);
            var rcntDivSearch = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Id, "rcnt", PropertyExpressionOperator.EqualTo)
            };
            var rcntDiv = resultsDiv.Find<HtmlDiv>(rcntDivSearch);
            var centerColDivSearch = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Id, "center_col", PropertyExpressionOperator.EqualTo)
            };
            var centerColDiv = rcntDiv.Find<HtmlDiv>(centerColDivSearch);
            var searchDivSearch = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Id, "search", PropertyExpressionOperator.EqualTo)
            };
            var searchDiv = centerColDiv.Find<HtmlDiv>(searchDivSearch);
            var iresDivSearch = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Id, "ires", PropertyExpressionOperator.EqualTo)
            };
            var iresDiv = searchDiv.Find<HtmlDiv>(iresDivSearch);
            var searchConditions = new PropertyExpressionCollection
            {
                new PropertyExpression(HtmlControl.PropertyNames.Class, "nrgt", PropertyExpressionOperator.EqualTo)
            };
            var nugetResultTable = iresDiv.Find<HtmlTable>(searchConditions);
            var condition = new PropertyExpressionCollection
                    {
                        new PropertyExpression(HtmlControl.PropertyNames.Class, "l",
                            PropertyExpressionOperator.EqualTo),
                        new PropertyExpression(HtmlControl.PropertyNames.InnerText, innerText,
                            PropertyExpressionOperator.EqualTo)
                    };
            return nugetResultTable.Find<HtmlHyperlink>(condition);
        }
    }
}