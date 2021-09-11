using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HomeWorkGB
{
    
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("                Задание № 1");
            Console.WriteLine();
            TaskStrings(10000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                Задание № 2");
            Console.WriteLine();
            TaskTree();
        }
        public static void TaskStrings(int count)
        {
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
            Console.WriteLine($"Время поиска в HashSet: {timer.Elapsed}");
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
                if (array[i] == test)
                {
                    Console.WriteLine($"Элемент '{array[i]}' найден в массиве");
                    check = false;
                    break;
                }
            }
            timer.Stop();
            Console.WriteLine($"Время поиска в массиве: {timer.Elapsed}");
            if (check)
            {
                Console.WriteLine($"Элемент '{test}' не найден в массиве.");
            }
        }



        public static void TaskTree()
        {
            var tree = new Tree(15);
            Console.WriteLine("Строим дерево с корнем 15");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0);
            Console.WriteLine();
            Console.WriteLine("Добавляем в дерево значения кратные 3 (3, 6, 9, ..., 42)" );
            for (int i = 1; i < 15; i++)              
            {
                tree.AddItem(i * 3);
            }
            Console.WriteLine("Теперь дерево выглядит так:");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0); 
            Console.WriteLine();
            int search = 27;
            var res = tree.GetNodeByValue(search);
            Console.WriteLine($"Результат поиска элемента со значением {search} -   L: {res.LeftChild?.Value}    P: {res.Parent?.Value}       R {res.RightChild?.Value}               Value {res.Value}");
            tree.RemoveItem(9);
            Console.WriteLine("Удаляем элемент со значением 9 (вместо со всеми его 'детьми')");
            Console.WriteLine("Теперь дерево выглядит так:");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0);
            Console.WriteLine();
            tree.AddItem(233);
            Console.WriteLine("Добавляем элемент 233");
            Console.WriteLine("Теперь дерево выглядит так:");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0);
            Console.WriteLine();
            tree.AddItem(234);
            Console.WriteLine("Добавляем элемент 234");
            Console.WriteLine("Теперь дерево выглядит так:");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0);
            Console.WriteLine();
            tree.AddItem(235);
            Console.WriteLine("Добавляем элемент 234");
            Console.WriteLine("Теперь дерево выглядит так:");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0);
            Console.WriteLine();
            tree.AddItem(239);
            Console.WriteLine("Добавляем элемент 239");
            Console.WriteLine("Теперь дерево выглядит так:");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0);
        }


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
    }
        
    }

