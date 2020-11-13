using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = 0;
            var odds = 0;

            evens = numbers.Where(num => num % 2 == 0).Sum();
            odds = numbers.Where(num => num % 2 != 0).Sum();

            return evens - odds;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lenList = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            var shortest = lenList.Min();
            return shortest;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int>() { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var triangle = false;

            if (sideLength1 > 0 && sideLength2 > 0 && sideLength3 > 0)
            {
                if (sideLength1 + sideLength2 > sideLength3 &&
                    sideLength2 + sideLength3 > sideLength1 &&
                    sideLength3 + sideLength1 > sideLength2)
                {
                    triangle = true;
                }
            }


            return triangle;
        }

        public bool IsStringANumber(string input)
        {
            double num = 0;
            bool result = double.TryParse(input, out num);
            return result;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = 0;

            foreach (var e in objs)
                if (e == null)
                {
                    nullCount++;
                }

            return (nullCount > objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            double result = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return result;
            }

            if (numbers.Where(num => num % 2 == 0).Sum() == 0)
            {
                return result;
            }

            result = numbers.Where(num => num % 2 == 0).Average();

            return result;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var result = 1;

            while (number >= 1)
            {
                result *= number;
                number--;
            }

            return result;
        }
    }
}
