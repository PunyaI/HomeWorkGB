using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Fibonacci
    {
        public static long count1 = 0;
        public static long count2 = 0;
        public static long RecursiveFibo(int n)
        {
            count1++;
            if (n == 0 || n == 1)
            {
                return n;
            } 
            else
            {
                return RecursiveFibo(n - 1) + RecursiveFibo(n - 2);
            }
        }

        public static long Fibo(int n)
        {
            int []numbers = new int[n];
            numbers[0] = 1;
            numbers[1] = 1;
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
                count2++;
            }
            return numbers[n-1];
        }
    }
}

