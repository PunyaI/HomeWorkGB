using System;


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
            int[] mas = new int[20];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(0, 20);
            }
            PrintArray(mas);
            BucketSort.DoBucketSort(mas);
            PrintArray(mas);
        }

    }
}

