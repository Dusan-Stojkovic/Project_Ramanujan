using System.Collections.Generic;

namespace Project_Ramanujan
{
    public partial class DynamicBaseNum
    {
        //A table created from all digits needed to complete the operation 
        private static (List<int>, List<int>) lrDigits;

        //Prepare the addition table
        private static void initTuple(string left, string right, int sBase)
        {
            //This tells us how many digits to set in table
            lrDigits.Item1 = new List<int>();
            lrDigits.Item2 = new List<int>();
            int i = 0;
            while (i < left.Length || i < right.Length)
            {
                lrDigits.Item1.Add(0);
                lrDigits.Item2.Add(0);
                ++i;
            }
            testNumbers(left, right, sBase);      //Here the table of digits is filled up
        }
        //This is where the addition happens
        private static string addition(int sBase)
        {
            string result = "";     //Note result here is inverted!
            int remainder = 0;
            for (int i = 0; i < lrDigits.Item1.Count; i++)
            {
                int digitValue = lrDigits.Item1[i] + lrDigits.Item2[i] + remainder;
                remainder = 0;
                if (digitValue >= sBase)
                {
                    result += range[digitValue - sBase];
                    while (digitValue >= sBase)
                    {
                        //Calculate the remainder
                        digitValue -= sBase;
                        remainder += 1;
                    }
                }
                else
                {
                    result += range[digitValue];
                }
            }
            if (remainder != 0)
            {
                result += remainder.ToString();
            }
            return Reverse(result);
        }

        //Here we reverse the string
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            System.Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}