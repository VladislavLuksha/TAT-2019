using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringTransliteration;

namespace StringTransliterationTest
{
    [TestClass]
    public class StringTest
    {
        Transliteration transliteration = new Transliteration();
        [TestMethod]
        public void TestMethodTranslationFromRussianToEnglish()
        {
            Assert.AreEqual("DOM", transliteration.TranslationFromRussianIntoEnglish("ДОМ"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussian()
        {
            Assert.AreEqual("СТОЛ", transliteration.TransliteEnglishString("STOL"));
        }
        [TestMethod]
        public void TestCheckMethodTranslationFromRussianToEnglishToRegister()
        {
            Assert.AreEqual("STUL", transliteration.TranslationFromRussianIntoEnglish("стул"));
        }
        [TestMethod]
        public void TestCheckMethodTranslationFromEnglishToRussianToRegister()
        {
            Assert.AreEqual("ДОСКА", transliteration.TransliteEnglishString("doska"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_SCH()
        {
            Assert.AreEqual("ЩУКА", transliteration.TransliteEnglishString("schuka"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_YU()
        {
            Assert.AreEqual("ЮЛА", transliteration.TransliteEnglishString("yula"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_YA()
        {
            Assert.AreEqual("ЯМА", transliteration.TransliteEnglishString("yama"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_SH()
        {
            Assert.AreEqual("ШИШКА", transliteration.TransliteEnglishString("shishka"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_СH()
        {
            Assert.AreEqual("ЧАР", transliteration.TransliteEnglishString("char"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_KH()
        {
            Assert.AreEqual("ХВОЯ", transliteration.TransliteEnglishString("khvoya"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_ZH()
        {
            Assert.AreEqual("ЖЕНА", transliteration.TransliteEnglishString("zhena"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToUniqueCase_YO()
        {
            Assert.AreEqual("ЁЛКА", transliteration.TransliteEnglishString("yolka"));
        }
        [TestMethod]
        public void TestMethodTranslationFromEnglishToRussianToException_SymbolIsSigns()
        {
            Assert.ThrowsException<InvalidFormatStringException>(() => transliteration.TranslationFromRussianIntoEnglish("1d4.eda"));
        }
        [TestMethod]
        public void TestMethodTranslationFromRussianToEnglishToException_SymbolIsSigns()
        {
            Assert.ThrowsException<InvalidFormatStringException>(() => transliteration.TranslationFromRussianIntoEnglish("16{мама~"));
        }
        [TestMethod]
        public void TestMethodTranslationFromRussianToEnglishToStringEmpty()
        {
            Assert.AreEqual(null, transliteration.TransliteEnglishString(null));
        }
        [TestMethod]
        public void TestMethodTranslationFromRussianToEnglishToDifferentLetters()
        {
            Assert.ThrowsException<InvalidFormatStringException>(() => transliteration.TranslationFromRussianIntoEnglish("mamaпапа"));
        }
    }
}
