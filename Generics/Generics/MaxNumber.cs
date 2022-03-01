using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxNumber
    {
        public int GetMaxOfThree(int firstNum, int secondNum, int thirdNum)
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
    }
}
