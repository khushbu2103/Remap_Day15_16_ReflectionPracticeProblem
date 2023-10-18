using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day15_16_ReflectionPracticeProblem
{
    internal class NearestNumber
    {
        public static void FindNearestNumber()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            //int closest = int.MaxValue;
            //for (int i = 0; i <= n; i++)
            //{
            //    if (i % 2 == 0 && HasAllEvenDigits(i))
            //    {
            //        if (Math.Abs(n - i) < Math.Abs(n - closest))
            //        {
            //            closest = i;
            //        }
            //    }
            //}
            //Console.WriteLine(closest);
            //bool isEven = false;
            int left = 0;
            int right = 0;
            if (n / 2 == 0) // 18
            {
                right = n + 2; // 18 + 2 = 20
                left = n - 2; // 18 - 2 = 18
            }
            else
            {
                right = n + 1;
                left = n - 1;
            }

            int rightNum = 0;
            int leftNum = 0;
            bool rightBool = false;
            bool leftBool = false;
            while (rightBool == false && leftBool == false)
            {
                if(HasAllEvenDigits(right))
                {
                    rightNum = right;
                    rightBool = true;
                }
                if(HasAllEvenDigits(left))
                {
                    leftNum = left;
                    leftBool = true;
                }
                right = right + 2;
                left = left - 2;
            }
            int closestEvenDigitedNumber = 0;
            if(rightBool == true && leftBool == true)
            {
                closestEvenDigitedNumber = leftNum;
            }
            else if(rightBool == true && leftBool == false)
            {
                closestEvenDigitedNumber = rightNum;
            }
            else if(rightBool == false && leftBool == true)
            {
                closestEvenDigitedNumber = leftNum;
            }
            Console.WriteLine(closestEvenDigitedNumber);
        }
        static bool HasAllEvenDigits(int n)
        {
            while (n > 0)
            {
                if ((n % 10) % 2 != 0)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

       
    }

}
