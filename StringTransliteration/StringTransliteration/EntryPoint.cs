using System;

namespace StringTransliteration
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Transliteration transliteration = new Transliteration();
            string myString = Console.ReadLine();
            try
            {
                Console.WriteLine(transliteration.TranslationFromRussianIntoEnglish(myString));
                Console.WriteLine(transliteration.TransliteEnglishString(transliteration.TranslationFromRussianIntoEnglish(myString)));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
