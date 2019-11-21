using System;
using System.Collections.Generic;
using System.Linq;

namespace StringTransliteration
{
    /*
     Transliteration class.
     This class translates a string.
     */
    public class Transliteration
    {
        Dictionary<char, string> russianDictionary = new Dictionary<char, string>
        {
            { 'А',"A"},{'Б',"B"},{'В',"V"},{'Г',"G"},{'Д',"D"},{'Е',"E"},{'Ё',"YO"},{'Ж',"ZH"},{'З',"Z"},{'И',"I"},{'Й',"Y"},{'К',"K"},{'Л',"L"},
            { 'М',"M"},{'Н',"N"},{'О',"O"},{'П',"P"},{'Р',"R"},{'С',"S"},{'Т',"T"},{ 'У',"U"},{'Ф',"F"},{'Х',"KH" },{'Ц',"TS"},{'Ч',"CH"},
            { 'Ш',"SH"},{ 'Щ',"SCH"},{ 'Ы',"Y"},{ 'Э',"E"},{ 'Ю',"YU"},{ 'Я',"YA"}
        };

        Dictionary<char, char> englishDictionary = new Dictionary<char, char>
        {
            {'A','А' },{ 'B','Б'},{ 'V','В'},{ 'G','Г'},{'D','Д' },{'E','Е' },{'Z','З' },{'I','И' },{'Y','У' },{'K','К'},{ 'L','Л'},
            {'M','М' },{ 'N','Н'},{ 'O','О'},{ 'P','П'},{'R','Р' },{ 'S','С'},{'T','Т' },{ 'U','У'},{'F','Ф' }
        };

        Dictionary<string, char> uniqueDictionary = new Dictionary<string, char>
        {
            {"YO",'Ё'},{"ZH",'Ж'},{"KH",'Х' },{"TS",'Ц' },{"CH",'Ч' },{"SH",'Ш' },{ "SCH",'Щ'},{ "YU",'Ю'},{ "YA",'Я'}
        };

        /*
         This method translates a input string characters from Russian to English.
         myString is input string.
         */ 
        public string TranslationFromRussianIntoEnglish(string myString)
        {
            string resultString = null;
            myString = myString.ToUpper();
            CheckStringForSymbols(myString);
            foreach(char element in myString)
            {
                if (russianDictionary.ContainsKey(element))
                {
                    resultString += russianDictionary[element];
                }
            }
            return resultString;
        }

        /*
         This method translates a input string characters from English to Russian.
         myString is input string.
         */
        public string TransliteEnglishString(string myString)
        {
            string resultString = null;
            myString = myString.ToUpper();
            CheckStringForSymbols(myString);
            for (int i = 0; i < myString.Length; i++)
            {
                if (i <= myString.Length - 2 && uniqueDictionary.ContainsKey(myString.Substring(i, 2)))
                {
                    resultString += uniqueDictionary[myString.Substring(i, 2)];
                    i += 1;
                }
                else if (i < myString.Length - 3 && uniqueDictionary.ContainsKey(myString.Substring(i, 3)))
                {
                    resultString += uniqueDictionary[myString.Substring(i, 3)];
                    i += 2;
                }
                else
                {
                    resultString += englishDictionary[myString[i]];
                }
            }
            return resultString;
        }
        private void CheckStringForSymbols(string myString)
        {
            foreach(char element in myString)
            {
                if(element >= 33 && element <= 64 || element >= 91 && element <= 96 || element >= 123 && element <= 127)
                {
                    throw new Exception("Character is not letter!");
                }
            }
        }
    }
}
