using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Massive
    {
        private string[,] mas { get; set; }
        private int[,] masiv { get; set; }
        public Massive(string[,] mas)
        {
            if (mas.GetLength(0) != 4 || mas.GetLength(1) != 4)    //вызываем исключение в конструкторе, если получаем массив не 4 на 4
            {
                throw new MyArraySizeException("Неверная размерность массива, должен быть 4 на 4");
            }
            else
            {
                this.mas = mas;
            }
           
        }
        public Massive (int[,] mas)
        {
            this.masiv = mas;
        }
        private int SumOfElements(string[,] mas)      //метод, вовзвращающий сумму всех элементов массива строк
        {
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    int value;
                    bool flag = Int32.TryParse(mas[i, j], out value);       //проверяем элемент на возможность конвертирования и вызываем исключение
                    if (!flag)
                    {
                        throw new MyArrayDataException("Ошибка! Некорректное значение в ячейке ", i, j);
                    }
                    else
                    {
                        sum += value;
                    }
                }
            }
            return sum;
        }
        private int SumOfElements(int[,] masiv)       //метод, вовзвращающий сумму всех элементов массива чисел
        {
            int sum = 0;
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    sum += masiv[i, j];
                }
            }
            return sum;
        }
        public static void WriteSumOfMassive(string [,] mas)   //метод вывода суммы элементов массива string
        {
            Massive mass = new Massive(mas);
            int sum = mass.SumOfElements(mas);
            Console.WriteLine(sum);
        }
        public static void WriteSumOfMassive(int[,] massiv)   //метод вывода суммы элементов массива int 
        {
            Massive mass = new Massive(massiv);
            int sum = mass.SumOfElements(massiv);
            Console.WriteLine(sum);
        }
        public static int[,] ReadMassive4x4()             //метод для считывания массива 4 на 4 с консоли
        {
            bool flag;
            int[,] masiv = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Введите элемент массива {i},{j} ");
                    int val;
                    flag = Int32.TryParse(Console.ReadLine(), out val);
                    while (!flag)
                    {
                        Console.WriteLine("Некорректное значение, введите число");
                        flag = Int32.TryParse(Console.ReadLine(), out val);
                    }
                    masiv[i, j] = val;
                }
                Console.WriteLine();
            }
            return masiv;
        }
        
    }
}
