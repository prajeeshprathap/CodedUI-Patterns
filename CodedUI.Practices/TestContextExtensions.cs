using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUI.Practices
{
    public static class TestContextExtensions
    {
        public static IList<string> GetCurrentTestCategories(this TestContext context)
        {
            var testClassType = Assembly.GetExecutingAssembly().GetType(context.FullyQualifiedTestClassName);
            var testMethodInfo = testClassType.GetMethod(context.TestName);
            if (testMethodInfo == null)
            {
                return new List<string>();
            }
            var testCategoryAttribute = testMethodInfo.GetCustomAttribute<TestCategoryAttribute>();
            if (testCategoryAttribute == null)
            {
                return new List<string>();
            }
            return testCategoryAttribute.TestCategories;
        }
    }
}