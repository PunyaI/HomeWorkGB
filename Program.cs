using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры массива");
            Console.Write("Количество строк: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int [,] mas = Masive.CreateMasive(y,x);
            int count = 1;
            int lineright = 0;
            int lineleft = mas.GetLength(0)-1;
            int columndown = mas.GetLength(1)-1;
            int columnup = 0;
            do                                                           //заполняем массив по кругу, увеливая или уменьшая индексы строк и столбцов
            {
                count = Masive.CountLine(mas, true, lineright, count);
                lineright++;
                count = Masive.CountStolb(mas, true, columndown, count);
                columndown--;
                count = Masive.CountLine(mas, false, lineleft, count);
                lineleft--;
                count = Masive.CountStolb(mas, false, columnup, count);
                columnup++;
                if (Masive.IsFull(mas))              //если массив заполнен - выходим из цикла
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Ваш массив, заполненный по спирали: ");
            Masive.WriteMas(mas);
        }
       
    }
}
