using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxNumber<T> where T : IComparable                   //Generic class
    {
        public T[] genValue;

        public MaxNumber(T[] genValue)                      //Constructor
        {
            this.genValue = genValue;
        }

        public T[] Sorting(T[] genValue)
        {
            Array.Sort(genValue);
            Array.Reverse(genValue);
            return genValue;
        }

        public T GetMaxOfThree(T[] genValue)
        {
            var sortedArray = Sorting(genValue);
            return sortedArray.ElementAt(0);
        }
        public T GetMax()
        {
            T maxValue = GetMaxOfThree(this.genValue);
            return maxValue;
        }

    }
}
