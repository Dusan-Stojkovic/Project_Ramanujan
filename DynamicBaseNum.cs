using System;
using System.Collections.Generic;

namespace Project_Ramanujan
{
    public partial class DynamicBaseNum
    {
        //Accepted digits in number:
        private static readonly char[] range =
        {
            '0','1','2','3','4'
            ,'5','6','7','8','9'
            ,'A','B','C','D','E'
            ,'F'
        };

        public static string Addition(string left, string right, string uBase)
        {
            try
            {
                string solution = "";
                if (rIsGood(uBase))
                {
                    int sBase = int.Parse(uBase);
                    initTuple(left, right, sBase);
                    solution = addition(sBase);
                    return solution;

                }
                return solution;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void testNumbers(string left, string right, int inputBase)
        {
            //The main test var
            bool numberIsGood = false;
            //Special test for the first digit
            for (int i = 0; i < inputBase; i++)
            {
                if (left[left.Length-1].Equals(range[i]))
                {
                    numberIsGood = true;
                    lrDigits.Item1[0] = i;
                    break;
                }
            }
            if (numberIsGood)
            {
                //The test that every digit after must pass:
                for (int i = 1; i < left.Length; i++)
                {
                    for (int j = 1; j < inputBase; j++)
                    {
                        if (left[left.Length-(i+1)].Equals(range[j]))
                        {
                            numberIsGood = true;
                            lrDigits.Item1[i] = j;
                        }
                    }
                    if (!numberIsGood) 
                    { 
                        Exception ex = new Exception("Nepoznati karakteri su uneti za brojeve. ");  //Fail for other digits
                        throw ex;
                    }
                }
            }
            else
            {
                Exception ex = new Exception("Nepoznati karakteri su uneti za brojeve. ");      //Fail for first digit
                throw ex;
            }

             //The main test var
            numberIsGood = false;
            //Special test for the first digit
            for (int i = 0; i < inputBase; i++)
            {
                if (right[right.Length-1].Equals(range[i]))
                {
                    numberIsGood = true;
                    lrDigits.Item2[0] = i;
                    break;
                }
            }
            if (numberIsGood)
            {
                //The test that every digit after must pass:
                for (int i = 1; i < right.Length; i++)
                {
                    for (int j = 1; j < range.Length; j++)
                    {
                        if (right[right.Length-(i+1)].Equals(range[j]))
                        {
                            numberIsGood = true;
                            lrDigits.Item2[i] = j;
                        }
                    }
                    if (!numberIsGood) 
                    { 
                        Exception ex = new Exception("Nepoznati karakteri su uneti za brojeve. ");  //Fail for other digits
                        throw ex;
                    }
                }
            }
            else
            {
                Exception ex = new Exception("Nepoznati karakteri su uneti za brojeve. ");      //Fail for first digit
                throw ex;
            }
        }

        private static bool rIsGood(string input)
        {
            if (int.TryParse(input, out int ibase))   //Test to see if input value is usable
            {
                if (ibase <= range.Length && ibase >= 2)
                {
                    return true;
                }
                else
                {
                    Exception ex = new Exception("Baze se sabiraju samo za vrednosti [2,16]");
                    throw ex;
                }
            }
            else
            {
                Exception ex = new Exception("Nepoznata baza, pokusaj ponovo");
                throw ex;
            }
        }
    }
}