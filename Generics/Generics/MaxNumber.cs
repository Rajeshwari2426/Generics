using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxNumber<T> where T : IComparable                   //Generic class
    {
        public T firstNum, secondNum, thirdNum;

        public MaxNumber(T firstNum, T secondNum, T thirdNum)                      //Constructor
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.thirdNum = thirdNum;
        }
            //Generics Method to generate max num
        public  static T GetMaxOfThree(T firstNum, T secondNum, T thirdNum) 
        {
            if (firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) >= 0)
            {
                return firstNum;
            }
            else if (secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) >= 0)
            {
                return secondNum;
            }
            else if (thirdNum.CompareTo(firstNum) >= 0 && thirdNum.CompareTo(secondNum) >= 0)
            {
                return thirdNum;
            }
            return default;
        }
        public T GetMax()
        {
            T maxValue = MaxNumber<T>.GetMaxOfThree(this.firstNum, this.secondNum, this.thirdNum);
            return maxValue;
        }

    }
}
