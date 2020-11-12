using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var sum = 0;

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var nums = 0;
            var uppers = 0;
            var lowers = 0;

            foreach (var c in password)
            {
                if (c >= 48 && c <= 57)
                {
                    nums++;
                }
                else if (c >= 65 && c <= 90)
                {
                    uppers++;
                }
                else if (c >= 97 && c <= 122)
                {
                    lowers++;
                }

            }

            return (nums > 0) && (uppers > 0) && (lowers > 0);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result = 0;

            if (divisor != 0)
            {
                result = dividend / divisor;
            }
            return result;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var intArray = new int[50];
            var oddNum = 1;

            for (int i = 0; i < 50; i++)
            {
                intArray[i] = oddNum;
                oddNum += 2;
            }

            return intArray;

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }    

        }
    }
}
