using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalTest.Test
{
    [TestClass]
    public class Assignment2Tests
    {
        [TestMethod]
        public void IsValidBraces_ValidExpression()
        {
            var expressionToTest = "(123456+23)";

            Assert.IsTrue(Assignment2.IsValidBraces(expressionToTest));
        }

        [TestMethod]
        public void IsValidBraces_InvalidExpression()
        {
            var expressionToTest = "(12345)6+23)";

            Assert.IsFalse(Assignment2.IsValidBraces(expressionToTest));
        }
    }
}
