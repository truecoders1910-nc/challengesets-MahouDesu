using System;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int AddEvens = 0;
            int SubOdds = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    AddEvens += num;
                }
                if (num % 2 != 0)
                {
                    SubOdds += num;
                }
            }
            return AddEvens - SubOdds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int SmallestString = str1.Length;
            if (SmallestString >= str1.Length)
            {
                SmallestString = str1.Length;
            }
            if (SmallestString >= str2.Length)
            {
                SmallestString = str2.Length;
            }
            if (SmallestString >= str3.Length)
            {
                SmallestString = str3.Length;
            }
            if (SmallestString >= str4.Length)
            {
                SmallestString = str4.Length;
            }
            return SmallestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int SmallestNumber = number1;
            if (SmallestNumber >= number1)
            {
                SmallestNumber = number1;
            }
            if (SmallestNumber >= number2)
            {
                SmallestNumber = number2;
            }
            if (SmallestNumber >= number3)
            {
                SmallestNumber = number3;
            }
            if (SmallestNumber >= number4)
            {
                SmallestNumber = number4;
            }
            return SmallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }
            double number = 0;
            bool reply = double.TryParse(input, out number);
            return reply;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            int AvgEvens = 0;
            int count = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    AvgEvens += num;
                    count++;
                }
            }
            double finalAVG = AvgEvens / count;
            return finalAVG;
        }

        public int Factorial(int number)
        {
            int test = number;
            int fact = 1;
            if (test < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;

        }
    }
}
