using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringOperations;

namespace StringOperationTests
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void TestSearchForIdenticalCharacters()
        {
            StringAnalyzer strings = new StringAnalyzer();
            Assert.AreEqual(3, strings.SearchForIdenticalCharacters("AAAaakke"));
            Assert.AreEqual(4, strings.SearchForIdenticalCharacters("фффллллщщщели"));
            Assert.AreEqual(5, strings.SearchForIdenticalCharacters("1225588888765"));
            Assert.AreEqual(0, strings.SearchForIdenticalCharacters("djkilasd;"));
            Assert.AreEqual(0, strings.SearchForIdenticalCharacters(""));
        }
        [TestMethod]
        public void TestSearchForUnequalCharacters()
        {
            StringAnalyzer strings = new StringAnalyzer();
            Assert.AreEqual(5, strings.SearchForUnequalCharacters("12234577"));
            Assert.AreEqual(5, strings.SearchForUnequalCharacters("aAAagrtt"));
            Assert.AreEqual(0, strings.SearchForUnequalCharacters(""));
            Assert.AreEqual(0, strings.SearchForUnequalCharacters("aaaaaaa"));
        }
        [TestMethod]
        public void TestSearchIdenticalLatinCharacters()
        {
            StringAnalyzer strings = new StringAnalyzer();
            Assert.AreEqual(0, strings.SearchIdenticalLatinCharacters(""));
            Assert.AreEqual(0, strings.SearchIdenticalLatinCharacters("1233343"));
            Assert.AreEqual(3, strings.SearchIdenticalLatinCharacters("dgglll5555345"));
            Assert.AreEqual(0, strings.SearchIdenticalLatinCharacters("afdtfuthr"));
            Assert.AreEqual(4, strings.SearchIdenticalLatinCharacters("AlllDDDD5]]]]"));
        }
    }
}
