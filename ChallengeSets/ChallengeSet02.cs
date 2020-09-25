using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (char.IsLetter(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (Math.Abs(num) % 2 > 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers == null || numbers.Count() == 0) ? 0 : (numbers.Min() + numbers.Max());
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int str1Length = str1.Length;
            int str2Length = str2.Length;

            return (str1Length <= str2Length) ? str1Length : str2Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers == null) ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            else
            {
                int count = 0;
                foreach (var elements in numbers)
                {
                    if (elements % 2 == 0)
                    {
                        count += elements;
                    }
                }
                return count;      
                
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number < 0 ? 0 : number / 2;
        }
    }
}
