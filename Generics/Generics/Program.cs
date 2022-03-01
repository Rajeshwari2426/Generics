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
                    MaxNumber<int> intMax = new MaxNumber<int>(intArray);
                    intMax.PrintMax();
                    break;
                case 2:
                    float[] floatArray = { 26.02f, 24.07f, 97.78f };
                    MaxNumber<float> floatMax = new MaxNumber<float>(floatArray);
                    floatMax.PrintMax();
                    break;
                case 3:
                    string[] strArray = { "tom", "jerry", "noddy", "oswald" };
                    MaxNumber<string> strMax = new MaxNumber<string>(strArray);
                    strMax.PrintMax();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
                   
            }
            Console.ReadLine();
        }

    }
}
