using System;
using System.Collections.Generic;
using static System.Console;

namespace Project_Ramanujan
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Za početak unesite vrednost baze: ");
                Write("r = ");
                string uBase = ReadLine();
                //string uBase = args[0];
                Write("Unesi vrednost za levu promenjivu: ");
                string left = ReadLine();
                //string left = args[1];
                Write("Unesi vrednost za desnu promenjivu: ");
                string right = ReadLine();
                //string right = args[2];
                try
                {
                    WriteLine(left + " + " + right + " = " + DynamicBaseNum.Addition(left, right, uBase));
                }
                catch(Exception ex)
                {
                    WriteLine(ex.Message);
                }
                string input = "";
                while(input != "Y" && input != "N" && input != "y" && input != "n")
                {
                    Write("Da li želite da izađete iz aplikacije? [y/N] ");
                    input = ReadLine();
                    if(input == "Y" || input =="y")
                    {
                        Environment.Exit(0);
                    }
                    else if(input == "N" || input == "n")
                    {
                        break;
                    }
                    WriteLine("Nepoznata komanda. Pokušaj ponovo.");
                }
            }
        }
    }
}
