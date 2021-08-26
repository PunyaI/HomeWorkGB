using System;
using System.Diagnostics;

namespace HomeWorkGeekBrains
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            var testcase1 = new TestCase()
            {
                input = "137",
                expected = true,
                expectedException = null
            };
            var testcase2 = new TestCase()
            {
                input = "47",
                expected = true,
                expectedException = null
            };
            var testcase3 = new TestCase()
            {
                input = "49",
                expected = false,
                expectedException = null
            };
            Test(testcase1);
            Test(testcase2);
            Test(testcase3);
            Console.WriteLine();

            //Задание №2
            //Асимптотическая сложность функции из примера - O(N^3)

            //Задание №3
            int num = 5;
            Stopwatch time = new Stopwatch();
            for (int i = num; i < 50; i+=10)
            {
                Fibonacci.count1 = 0;
                Fibonacci.count2 = 0;
                time.Start();
                Console.WriteLine($"{i} число Фибонаначи: {Fibonacci.RecursiveFibo(i)}");
                time.Stop();
                Console.WriteLine($"Рекурсивное вычисление {i} числа Фибонначи заняло: {time.ElapsedMilliseconds} милисекунд и {Fibonacci.count1} итераций");
                time.Reset();
                time.Start();
                Console.WriteLine($"{i} число Фибонаначи: {Fibonacci.Fibo(i)}");
                time.Stop();
                Console.WriteLine($"Цикличное вычисление {i} числа Фибонначи заняло: {time.ElapsedMilliseconds} милисекунд и {Fibonacci.count2} итераций");
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }

        public class TestCase
        {
            public string input { get; set; }
            public bool expected { get; set; }
            public Exception expectedException { get; set; }
        }

        static void Test(TestCase testCase)
        {
            try
            {
                var actual = IsSimpleNumber(testCase.input);
                if (actual == testCase.expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception e)
            {
                if (testCase.expectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static bool IsSimpleNumber(string input)
        {
            if (!Int32.TryParse(input, out int n))
            {
                throw new ArgumentException("Должно быть введено число!");
            }
            else if (n <= 0)
            {
                throw new ArgumentException("Число должно быть положительное (больше 0)!");
            }
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
