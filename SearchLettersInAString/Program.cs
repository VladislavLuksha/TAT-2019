using System;

namespace SearchLettersInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line("bablllltkdllljll");
            int maxNumberOfSymbols = line.SearchForTheMaxNumberOfSymbols();
            Console.WriteLine($"Maximum number of symbols in string = {maxNumberOfSymbols}");
        }
    }
}
