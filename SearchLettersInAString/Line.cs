using System;

namespace SearchLettersInAString
{
    class Line
    {
        string line;
        const int startCounter = 1;

        public Line(string line)
        {
            this.line = line;
        }

        public int SearchForTheMaxNumberOfSymbols()
        {
            int currentNumberOfSymbols = 0;
            int maxNumberOfSymbols = 0;
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i - 1] == line[i])
                {
                    currentNumberOfSymbols++;
                }
                else
                {
                    currentNumberOfSymbols = startCounter;
                }
                if (currentNumberOfSymbols > maxNumberOfSymbols)
                {
                    maxNumberOfSymbols = currentNumberOfSymbols;
                }
            }
            return maxNumberOfSymbols;
        }
    }
}
