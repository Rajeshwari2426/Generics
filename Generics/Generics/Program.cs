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
           
            Console.Write("Please choose an option: ");
            Console.WriteLine("\n1. Find Max Of Three Int Number  \n2. Find Max Of Three Float Number \n3. Find Max Of Three Strings");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int[] intArray = { 26, 24, 02,04};
                    int intMax = new MaxNumber<int>(intArray).GetMax();
                    Console.WriteLine("Maximum of three integers is: " + intMax);
                    break;
                case 2:
                    float[] floatArray = { 26.02f, 24.07f, 97.78f }; 
                    float floatmax = new MaxNumber<float>(floatArray).GetMax();
                    Console.WriteLine("Maximum of three integers is: " + floatmax);
                    break;
                case 3:
                    string[] strArray = { "tom", "jerry", "noddy", "oswald" };
                    string stringMax = new MaxNumber<string>(strArray).GetMax();
                    Console.WriteLine("Maximum of three strings is: " + stringMax);
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
                   
            }
            Console.ReadLine();
        }

    }
}
