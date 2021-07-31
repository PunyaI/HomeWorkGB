using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Task4
    {
        static void main(string[] args)
        {
            Console.WriteLine("Введите номер числа Фибоначи");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = Fibonaci(n);
            Console.WriteLine($"{n}-ое число Фибоначи - {res}");
        }
        static int Fibonaci(int n)
        {
            if (n == 0)
            {
                return 0;
            } else if (n==1)
            {
                return 1;
            }
            return Fibonaci(n - 1) + Fibonaci(n - 2);
        }
            
    }
}

