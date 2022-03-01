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
            int intmax = maximum.GetMaxOfThree(26, 24,97);
            Console.WriteLine("Maximum of three integers is: " + intmax);
            Console.ReadLine();
        }
    }
}
