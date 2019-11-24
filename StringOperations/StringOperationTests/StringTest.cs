using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringOperations;

namespace StringOperationTests
{
    [TestClass]
    public class StringsTest
    {
        StringAnalyzer stringAnalyzer = new StringAnalyzer();

        [TestMethod]
        [DataRow(0, "")]
        [DataRow(0, "djkilasd;")]
        [DataRow(5, "1225588888765")]
        [DataRow(4, "фффллллщщщели")]
        [DataRow(3, "AAAaakke")]
        public void TestSearchForIdenticalCharacters(int expected, string temporaryString)
        {
            Assert.AreEqual(expected, stringAnalyzer.SearchForIdenticalCharacters(temporaryString));
        }

        [TestMethod]
        [DataRow(5, "12234577")]
        [DataRow(5, "aAAagrtt")]
        [DataRow(0, "")]
        [DataRow(0, "aaaaaaa")]
        public void TestSearchForUnequalCharacters(int expected, string temporaryString)
        {
            Assert.AreEqual(expected, stringAnalyzer.SearchForUnequalCharacters(temporaryString));
        }

        [TestMethod]
        [DataRow(0, "")]
        [DataRow(0, "1234567")]
        [DataRow(3, "dgglll5555345")]
        [DataRow(0, "kjdlqldcl")]
        [DataRow(4, "AlllDDDD5]]]]")]
        public void TestSearchIdenticalLatinCharacters(int expected,string temporaryString)
        {
            Assert.AreEqual(expected, stringAnalyzer.SearchIdenticalLatinCharacters(temporaryString));
        }
    }
}
