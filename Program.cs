using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HomeWorkGB
{
    class Program
    {
        public static string[] RandomStrings(int count)
        {
            var result = new string[count];
            var r = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                var length = r.Next(0, 15);
                var str = new StringBuilder(length);
                while (length > 0)
                {
                    str.Append((char)r.Next(0, 256));
                    length--;
                }
                result[i] = str.ToString();
            }
            result[count - 1] = "test";
            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("                Задание № 1");
            Console.WriteLine();
            int count = 20000;
            var strings = RandomStrings(count);
            var hashset = new HashSet<string>();
            string test = "test";
            for (int i = 0; i < count; i++)
            {
                hashset.Add(strings[i]);
            }
            var timer = new Stopwatch();
            timer.Start();
            bool check = hashset.Contains(test);
            timer.Stop();
            Console.WriteLine($"Время поиска: {timer.Elapsed}");
            if (check)
                
            {
                Console.WriteLine($"Элемент '{test}' найден в HashSet");
            }
            else
            {
                Console.WriteLine($"Элемент '{test}' не найден в HashSet");
            }
            
            
            timer.Reset();
            var array = strings;
            check = true;
            timer.Start();
            for (int i = 0; i < count; i++)
            {
                if(array[i]==test)
                {
                    Console.WriteLine($"Элемент '{array[i]}' найден в HashSet");
                    check = false;
                    break;
                }
            }
            timer.Stop();
            Console.WriteLine($"Время поиска: {timer.Elapsed}");
            if (check)
            {
                Console.WriteLine($"Элемент '{test}' не найден в массиве.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                Задание № 2");
            Console.WriteLine();













            //    Console.WriteLine();
            //    Console.WriteLine("                   Задание №2");
            //    Console.WriteLine();
            //    int[] array = { 2, 4, 5, 7, 9, 11, 15, 18, 23, 29, 32, 33, 36, 39, 40, 42, 44, 59, 89, 90 };
            //    int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //    var testcase1 = new TestCase()
            //    {
            //        input = array,
            //        inputsearch = 4,
            //        expected = 1,
            //        expectedException = null
            //    };
            //    var testcase2 = new TestCase()
            //    {
            //        input = array,
            //        inputsearch = 89,
            //        expected = 18,
            //        expectedException = null
            //    };
            //    var testcase3 = new TestCase()
            //    {
            //        input = array2,
            //        inputsearch = 9,
            //        expected = 8,
            //        expectedException = null
            //    };
            //    var testcase4 = new TestCase()
            //    {
            //        input = array2,
            //        inputsearch = 20,
            //        expected = 19,
            //        expectedException = null
            //    };
            //    var testcase5 = new TestCase()
            //    {
            //        input = array,
            //        inputsearch = -1,
            //        expected = 32,
            //        expectedException = new ArgumentException()
            //};

            //    TestCase.Test(testcase1);
            //    TestCase.Test(testcase2);
            //    TestCase.Test(testcase3);
            //    TestCase.Test(testcase4);
            //    TestCase.Test(testcase5);
        }
    }
        
    }

