using System;

namespace StringOperations
{
    /// <summary>
    /// This is entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {            
            string myString = Console.ReadLine();
            StringAnalyzer strings = new StringAnalyzer();
            Console.WriteLine("Maximum consecutive identical characters: " + strings.SearchForIdenticalCharacters(myString));
            Console.WriteLine("Maximum number of consecutive unequal characters : " + strings.SearchForUnequalCharacters(myString));
            Console.WriteLine("Maximum consecutive identical Latian characters: " + strings.SearchForIdenticalLatinCharacters(myString));
        }
    }
}
