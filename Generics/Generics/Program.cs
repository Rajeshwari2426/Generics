using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"Find Max of three numbers using generics\" program\n");
            MaxNumber maximum = new MaxNumber();
            Console.Write("Please choose an option: ");
            Console.WriteLine("\n1. Find Max Of Three Int Number \n2. Find Max Of Three Float Number");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int intnum1 = 66, intnum2 = 78, intnum3 = 56;
                    int intmax = maximum.GetMaxOfThree(intnum1, intnum2, intnum3);
                    Console.WriteLine("Maximum of three integers is: " + intmax);
                    break;
                case 2:
                    float floatnum1 = 26.02f, floatnum2 = 24.07f, floatnum3 = 97.78f;
                    float floatmax = maximum.GetMaxOfThree(floatnum1, floatnum2, floatnum3);
                    Console.WriteLine("Maximum of three integers is: " + floatmax);
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
                   
            }
            Console.ReadLine();
        }

    }
}
