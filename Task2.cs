using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Task2
    {
        static void main(string[] args)
        {
            Console.WriteLine("Введите числа, которые нужно сложить через пробел:");
            string source = Console.ReadLine();
            string[] values = source.Split();       //разделяем строку по пробелу в массив и передаем этот массив в метод
            int sum = Sum(values);                  
            Console.WriteLine(sum);
        }
        static int Sum(params string[] source)         
        {
            int sum = 0;
            for (int i = 0; i < source.Length; i++)
            {
                int value = Convert.ToInt32(source[i]);
                sum += value; 
            }
            return sum;
        }
    }
}

