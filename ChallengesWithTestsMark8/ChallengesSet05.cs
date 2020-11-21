using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var num = startNumber + 1;
            var result = 0;
            var looking = true;

            do
            {
                if (num % n == 0)
                {
                    result = num;
                    looking = false;
                }
                else
                {
                num++;
                }

            } while (looking);

            return result;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return sum;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var newString = "";
            var newWord = "";

            if (words == null || words.Length == 0)
            {
                return newString;
            }

            foreach (var w in words)
            {
                newWord = w.Trim();
                newString = newString + " " + newWord;
                newString = newString.Trim();
            }

            if (newString.Length == 0)
            {
                return newString;
            }
            else
            {
                return newString + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }

            var newList = new List<double>();

            var counter = 3;

            while (counter <= elements.Count - 1)
            {
                newList.Add(elements[counter]);
                counter += 4;
            }
           
            var resArray = newList.ToArray();           

            return resArray;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var sum = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];

                    if (sum == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
