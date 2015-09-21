using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;


namespace TechnicalTest.Test
{
    [TestClass]
    public class Assignment3Tests
    {
        [TestMethod]
        public void ExtractLargestNumbers_LargestTen()
        {
            string tempPath = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(tempPath))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine(i);
                }
            }

            var result = Assignment3.ExtractLargestNumbers(tempPath, 10);

            var expectedResult = new List<Double> { 99, 98, 97, 96, 95, 94, 93, 92, 91, 90 };

            CollectionAssert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ExtractLargestNumbers_EmptyList()
        {
            string tempPath = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(tempPath))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine("");
                }
            }

            var result = Assignment3.ExtractLargestNumbers(tempPath, 10);

            Assert.IsTrue(result.Count == 0);
        }
    }
}
