using System;

namespace StringOperations
{
    /// <summary>
    /// This class for string analysis.
    /// </summary>
    public class StringAnalyzer
    {
        /// <summary>
        /// This method searches for unequal characters.
        /// </summary>
        /// <param name="myString"> search string characters </param>
        /// <returns>maximum amount unequal characters </returns>
        public int SearchForUnequalCharacters(string myString)
        {
            int maxAmount = 1, amountOfElements = 1;
            for (int i = 1; i < myString.Length; i++)
            {
                if (myString[i] != myString[i - 1])
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
            if(maxAmount == 1 || myString == null)
            {
                maxAmount = 0;
            }
            return maxAmount;
        }
        public int SearchForIdenticalCharacters(string myString)
        {
            int maxAmount = 1, AmountOfElements = 1;
            for (int i = 1; i < myString.Length; i++)
            {
                if (myString[i] == myString[i - 1])
                {
                    AmountOfElements++;
                }
                else
                {
                    AmountOfElements = 1;
                }
                if (maxAmount <= AmountOfElements)
                {
                    maxAmount = AmountOfElements;
                }
            }
            if(maxAmount == 1 || myString == null)
            {
                maxAmount = 0;
            }
            return maxAmount;
        }
        public int SearchIdenticalLatinCharacters(string myString)
        {
            int maxAmount = 1, AmountOfTheElements = 1;
            for (int i = 1; i < myString.Length; i++)
            {
                if (myString[i] >= 91 && myString[i] <= 96 || myString[i-1] >= 91 && myString[i - 1] <= 96)
                {
                    continue;
                }
                if (myString[i] == myString[i - 1] && ((myString[i] >=65 && myString[i] >= 122) || (myString[i-1] >= 65 || myString[i-1] >= 122)))
                {
                    AmountOfTheElements++;
                }
                else
                {
                    AmountOfTheElements = 1;
                }
                if (maxAmount <= AmountOfTheElements)
                {
                    maxAmount = AmountOfTheElements;
                }
            }
            if (maxAmount == 1 || myString == null)
            {
                maxAmount = 0;
            }
            return maxAmount;
        }
    }
}
