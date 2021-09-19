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
                mas[i] = rand.Next(1, 10);
            }
            int[] mas1 = mas;
            Console.WriteLine("Исходный массив");
           PrintArray(mas);
            Console.WriteLine();
            var timer = new Stopwatch();
            Console.WriteLine("Блочная сортировка");
            timer.Start();
            DoBucketSort(mas);
            timer.Stop();
            Console.WriteLine($"Время выполнения: {timer.Elapsed}");
            timer.Reset();
            PrintArray(mas);
            Console.WriteLine();
            Console.WriteLine("Пузырьковая сортировка");
            timer.Start();
            BubleSort(mas1);
            timer.Stop();
            Console.WriteLine($"Время выполнения: {timer.Elapsed}");
            timer.Reset();
            PrintArray(mas1);
        }
        public static void DoBucketSort(int[] array)
        {
            if (array == null || array.Length < 2) return;
            int min = array[0];
            int max = array[0];
            bool is_sorted = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
                if (array[i] < array[i - 1]) is_sorted = false;
            }
            if (is_sorted) return;
            //List<int>[] bucket = new List<int>[max - min + 1];
            List<int>[] bucket = new List<int>[max % 10 + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i] % 10].Add(array[i]);
            }
            int n = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        array[n] = bucket[i][j];
                        n++;
                    }
                }
            }
        }
        static void BubleSort(int [] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int n = 0;
                for (int j = 0; j < array.Length-1; j++)
                {
                    if(array[i]>array[i+1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        n = 1;
                    }
                }
                if (n == 0)
                    break;
            }
        }
    }
}

