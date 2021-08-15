using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Masive
    {
        public static int[,] CreateMasive(int y, int x)
        {
            int[,] mas = new int[y, x];
           
            return mas;
        }
        public static void WriteMas(int [,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int CountLine(int [,] mas, bool nextORback, int yCurrent, int count)
        {
            int i = yCurrent;
            if (nextORback)                                              //выбираем куда нам идти заполнять, вперед или назад по индексам
            {
                    for (int j = 0; j < mas.GetLength(1); j++)              //заполняем в заданном направлении, пока есть незаполненные индексы
                    {
                        if ( mas[i,j]==0)
                        {
                            mas[i, j] = count;
                            count++;                                        //если поставили значение, то увеливаем счётчик и возвращаем его в конце
                        }
                    }
            } else
            {
                for (int j = mas.GetLength(1)-1; j >= 0 ; j--)
                {
                    if (mas[i, j] == 0)
                    {
                        mas[i, j] = count;
                        count++;
                    }
                }
            }
            return count;
        }
        public static int CountStolb(int[,] mas, bool nextORback, int xCurrent, int count)
        {
            int j = xCurrent;
            if (nextORback)                                  
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    if (mas[i, j] == 0)
                    {
                        mas[i, j] = count;
                        count++;
                    }
                }
            }
            else
            {
                for (int i = mas.GetLength(0)-1; i >= 0; i--)
                {
                    if (mas[i, j] == 0)
                    {
                        mas[i, j] = count;
                        count++;
                    }
                }
            }
            return count;
        }
        public static bool IsFull(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i,j]==0)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
