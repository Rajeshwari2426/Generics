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
        public float GetMaxOfThree(float firstNum, float secondNum, float thirdNum)
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
        public string GetMaxOfThree(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) >= 0 && str1.CompareTo(str3) >= 0)
            {
                return str1;
            }
            else if (str2.CompareTo(str1) >= 0 && str2.CompareTo(str3) >= 0)
            {
                return str2;
            }
            else if (str3.CompareTo(str1) >= 0 && str3.CompareTo(str2) >= 0)
            {
                return str3;
            }
            return default;
        }
    }
}
