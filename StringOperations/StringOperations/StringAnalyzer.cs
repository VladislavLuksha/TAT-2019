using System;

namespace StringOperations
{
    /// <summary>
    /// This class for string analysis.
    /// </summary>
    public class StringAnalyzer
    {
        /// <summary>
        /// This method counts maximum number of different characters
        /// </summary>
        /// <param name="myString"></param>
        /// <param name="func"></param>
        /// <returns>maxAmount</returns>
        private int CountMaxNumberOfCharacters(string myString,Func<string,int,bool> func)
        {
            int maxAmount = 1, amountOfElements = 1;
            for (int i = 1; i < myString.Length; i++)
            {
                if (func(myString,i))
                {
                    amountOfElements++;
                }
                else
                {
                    amountOfElements = 1;
                }
                if (maxAmount <= amountOfElements)
                {
                    maxAmount = amountOfElements;
                }
            }
            if (maxAmount == 1 || myString == null)
            {
                maxAmount = 0;
            }
            return maxAmount;
        }
        /// <summary>
        /// This method searches for unequal characters.
        /// </summary>
        /// <param name="myString"> search string characters </param>
        /// <returns>maximum amount unequal characters </returns>
        public int SearchForUnequalCharacters(string myString)
        {
            return CountMaxNumberOfCharacters(myString, (x, i) => x[i] != x[i - 1]);
        }
        /// <summary>
        /// This method seaches for identical characters
        /// </summary>
        /// <param name="myString"></param>
        /// <returns>maximum amount identical characters</returns>
        public int SearchForIdenticalCharacters(string myString)
        {
            return CountMaxNumberOfCharacters(myString, (x, i) => x[i] == x[i - 1]);
        }
        /// <summary>
        /// This method searches for identical latin characters
        /// </summary>
        /// <param name="myString"></param>
        /// <returns>maximum amount identical latin characters</returns>
        public int SearchForIdenticalLatinCharacters(string myString)
        { 
            return CountMaxNumberOfCharacters(myString, (x, i) => x[i] == x[i - 1] && 
            ((x[i] >= 65 && x[i] <= 90) || (x[i] >= 97 && x[i] <= 122)));
        }
    }
}
