using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
          if (words != null)
          {

            var testWord = "";

            if (ignoreCase)
            {
                testWord = word.ToUpper();
                foreach (var w in words.Where(w => w != null))
                {
                    if (testWord == w.ToUpper())
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (var w in words.Where(w => w != null))
                {
                    if (word == w)
                    {
                        return true;
                    }
                }
            }
          }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1)
            {
                return 0;
            }
            if (str.Length < 1)
            {
                return -1;
            }
 
            var counter = 0;
            var uniStr = "";
           
           for (int i = 0; i < str.Length; i++)
            {
                counter = str.Where(x => (x == str[i])).Count();
                if (counter == 1)
                {
                    uniStr += str[i];
                }
            }

           if (uniStr.Length > 0)
            {
            var lastLetter = uniStr[uniStr.Length - 1];
            var answer = str.LastIndexOf(lastLetter);
            return answer;
            }
            else
            {
                return -1;
            }
          
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var counter = 1;
            var tempCounter = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    tempCounter++;
                    if (tempCounter > counter)
                    {
                        counter = tempCounter;
                    }
                }
                else
                {
                    tempCounter = 1;
                }
            }

            return counter;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var newList = new List<double>();

            if (elements != null && elements.Count() != 0 && n > 0)
            {
                for (int i = n - 1; i < elements.Count(); i = i + n)
                {
                    newList.Add(elements[i]);
                }
            }

            var newArray = newList.ToArray();
            return newArray;
        }
    }
}
