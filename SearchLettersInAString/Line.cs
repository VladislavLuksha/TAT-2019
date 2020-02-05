using System;

namespace SearchLettersInAString
{
    /// <summary>
    /// This is string class
    /// </summary>
    class Line
    {
        string String { get; set; }
        const int startCounter = 1;

        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="line"></param>
        public Line(string line)
        {
            this.String = line;
        }
        /// <summary>
        /// This method searches for the maximum number of identical characters 
        /// </summary>
        /// <returns>maxNumberOfSymbols</returns>
        public int SearchForTheMaxNumberOfSymbols()
        {
            int currentNumberOfSymbols = 0;
            int maxNumberOfSymbols = 0;
            for (int i = 1; i < String.Length; i++)
            {
                if (String[i - 1] == String[i])
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
