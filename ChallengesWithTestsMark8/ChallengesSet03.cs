using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
            //foreach (bool item in vals)
            //{
            //    if (vals = bool.Parse(false))
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //created a bool variable for upper case, lower case, and digit.
            bool containsUpper = password.Any(char.IsUpper);
            bool containsLower = password.Any(char.IsLower);
            bool containsNumber = password.Any(char.IsDigit);

            //if statement that if you wanted true, then include all the variables above
            if (containsUpper && containsLower && containsNumber)
            {
                return true;
            }
            return false;

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
            try
            {
                return (dividend / divisor);
            }
            catch (DivideByZeroException)
            {

                return 0;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
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
