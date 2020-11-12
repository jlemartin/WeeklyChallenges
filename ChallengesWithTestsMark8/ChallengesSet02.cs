using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var newChar = char.ToUpper(c);
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (var letter in alphabet)
            {
                if (newChar == letter)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            var sum = 0.0;

            if (numbers != null && numbers.Count() > 0)
            {
            var min = numbers.Min();
            var max = numbers.Max();
            sum = min + max;
            }

            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var len1 = str1.Length;
            var len2 = str2.Length;

            if (len1 < len2)
            {
                return len1;
            }
            else
            {
                return len2;
            }
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;

            if (numbers != null && numbers.Count() > 0)
            {
                foreach (var n in numbers)
                {
                    sum += n;
                }
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;

            if (numbers != null && numbers.Count() > 0)
            {
                foreach (var n in numbers)
                {
                    if (n % 2 == 0)
                    {
                        sum += n;
                    }
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var result = false;

            var sum = 0;

            if (numbers != null && numbers.Count() > 0)
            {
                foreach (var n in numbers)
                {
                    sum += n;
                }
            }

            if (sum % 2 != 0)
            {
                result = true;
            }

            return result;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    count = number / 2;
                }
                else
                {
                    count = (number - 1) / 2;
                }
            }

            return count;
        }
    }
}
