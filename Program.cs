using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace HomeWorkGB
{
    class Program
    {
        static void PrintArray<T>(T []array)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] mas = new int[100];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(15,10000000);
            }
            
            int[] mas1 = new int[mas.Length];
            int[] mas2 = new int[mas.Length];
            int[] mas3 = new int[mas.Length];
            mas.CopyTo(mas1,0);
            mas.CopyTo(mas2, 0);
            mas.CopyTo(mas3, 0);
            Console.WriteLine("Исходный массив");
           //PrintArray(mas);
            Console.WriteLine();
            var timer = new Stopwatch();
            Console.WriteLine("Блочная сортировка подсчётом");
            timer.Start();
            MaxBucketsSort.Sort(mas);
            timer.Stop();
            Console.WriteLine($"Время выполнения: {timer.Elapsed}");
            timer.Reset();
            //PrintArray(mas);
            Console.WriteLine();
            Console.WriteLine("Блочная сортировка с пузырьковой внутри");
            timer.Start();
            BucketSort.Sort(mas1);
            timer.Stop();
            Console.WriteLine($"Время выполнения: {timer.Elapsed}");
            timer.Reset();
            //PrintArray(mas1);
            Console.WriteLine();
            Console.WriteLine("Блочная сортировка с автосортировкой List внутри");
            timer.Start();
            BucketSort.Sort(mas2, true);
            timer.Stop();
            Console.WriteLine($"Время выполнения: {timer.Elapsed}");
            timer.Reset();
            //PrintArray(mas2);
            Console.WriteLine();
            Console.WriteLine("Пузырьковая сортировка");
            timer.Start();
            BubleSort(mas3);
            timer.Stop();
            Console.WriteLine($"Время выполнения: {timer.Elapsed}");
            timer.Reset();
            //PrintArray(mas3);
        }
       
        static void BubleSort(int [] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int n = 0;
                for (int j = 0; j < array.Length-1; j++)
                {
                    if(array[j]>array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        n = 1;
                    }
                }
                if (n == 0)
                    break;
            }
        }
    }
}

