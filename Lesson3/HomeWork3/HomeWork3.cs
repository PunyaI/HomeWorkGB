using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class HomeWork3
    {
        private static void Main(string[] args)
        {
            ////Задание №1
            ///
            //int[,] array = new int[5, 5];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (i == j)                            //выводим диагональ
            //        {
            //            Console.Write(array[i, j]);
            //        }
            //        else
            //        {
            //            Console.Write("  ");             //выводим пробелы на месте не диагональных значений массива
            //        }
            //    }
            //    Console.WriteLine();                     //переводим курсор на следующую "строку"
            //}












            ////Задание №2
            //
            //string[,] phones = new string[5, 2];


            ////for (int i = 0; i < phones.GetLength(0); i++)     //Тестовое наполнение справочника одинаковыми значениями
            ////{
            ////    string name = "Андрей";
            ////    string num = "89998887766";              //Думаю в данном случае лаконичнее в одном цикле заполнять, массив, если мы не рассчитываем, что будем добавлять ещё "столбцы" в данный справочник
            ////    phones[i, 0] = name;
            ////    phones[i, 1] = num;
            ////}  


            //for (int i = 0; i < phones.GetLength(0); i++)        ///Цикл по заполнению справочника данными пользователя
            //{
            //    Console.WriteLine("Введите имя контакта:");
            //    string name = Console.ReadLine();
            //    phones[i, j] = name; 
            //    Console.WriteLine("Введите номер/email:");
            //    string num = Console.ReadLine();                             
            //    phones[i, 1] = num;
            //}
            //Console.WriteLine("  Вот Ваша телефонная книга:");
            //for (int i = 0; i < phones.GetLength(0); i++)
            //{
            //    for (int j = 0; j < phones.GetLength(1); j++)
            //    {
            //        Console.Write("    " + phones[i, j]);
            //    }
            //    Console.WriteLine();
            //}







            ////Задание №3

            //Console.WriteLine("Введите слово:");
            //string str = Console.ReadLine();
            //for (int i = str.Length-1; i >=0 ; i--)
            //{
            //    Console.Write(str[i]);
            //}
            //Console.WriteLine();





            ////Задание №4 

            //char[,] map = new char[10, 10];

            //for (int i = 0; i < map.GetLength(0); i++)      //заполняем всё поле нулями, если закомментировать цикл, то будет нагляднее видно корабли
            //{
            //    for (int j = 0; j < map.GetLength(1); j++)
            //    {
            //        map[i, j] = '0';
            //    }
            //}
            //map[4, 1] = 'X';                                 //строим корабли
            //map[4, 2] = 'X';
            //map[4, 3] = 'X';
            //map[4, 4] = 'X';

            //map[4, 7] = 'X';
            //map[5, 7] = 'X';
            //map[6, 7] = 'X';

            //map[6, 4] = 'X';
            //map[7, 4] = 'X';
            //map[8, 4] = 'X';

            //map[1, 6] = 'X';
            //map[2, 6] = 'X';

            //map[2, 3] = 'X';
            //map[2, 4] = 'X';

            //map[6, 1] = 'X';
            //map[6, 2] = 'X';

            //map[1, 1] = 'X';
            //map[1, 8] = 'X';
            //map[8, 1] = 'X';
            //map[8, 8] = 'X';

            //for (int i = 0; i < map.GetLength(0); i++)                   //выводим всё поле с кораблями
            //{
            //    for (int j = 0; j < map.GetLength(1); j++)
            //    {
            //        Console.Write(map[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //}













            /*
             Тут моя попытка написать программу, которая сама рисовала бы корабли, пытался написать сходу без алгоритма, просто расписав логику работы,
            но зашел в тупик, запутался сам в этом нагромождении и начал рисовать блок схемами на бумаге алгоритм.  И понял, что тут без использования хотя бы функций
            будет просто огромное количество очень сложночитаемого кода. А после просмотра курса основ ООП хочется всё таки такие задачи решать уже в объектно-ориентированном стиле.
            Поэтому решил остановиться и написать сейчас просто вывод в консоль, как озвучено в задаче. Этот код оставил в коммите, чтобы посмотреть на него позже.

            Инициализируем массив 10 на 10
            Как рисовать корабли - берём два случайных числа (i,j)
            Проверяем нет ли в этой ячейке уже корабля и  вокруг данной ячейки кораблей.
            Если чисто - рисуем палубу корабля и ставим следующую  палубу вверх и првоерям нет ли вокруг кораблей, 
            если нет, продолжаем, пока не нарисуем все палубы. Если есть, то проверям право, низ и лево,
            если также всё занято - выходим в начало цикла и выбираем другой случайный индекс и повторяем итерацию.
           

             */

            //char[,] map = new char[10, 10];
            //char ship = 'X';
            //char tmp1;
            //char tmp2;
            //char tmp3;
            //char tmp4;
            //char tmp5;
            //char tmp6;
            //char tmp7;
            //char tmp8;
            //char[] temp = new char[3];
            //int k = 1;
            //while (k < 4)
            //{
            //    int i;
            //    int j;
            //    do
            //    {
            //        Random rnd = new Random();
            //        i = rnd.Next(10);
            //        j = rnd.Next(10);

            //        tmp1 = map[i + 1, j];
            //        tmp2 = map[i + 1, j + 1];
            //        tmp3 = map[i + 1, j - 1];
            //        tmp4 = map[i - 1, j];
            //        tmp5 = map[i - 1, j + 1];
            //        tmp6 = map[i - 1, j - 1];
            //        tmp7 = map[i, j + 1];
            //        tmp8 = map[i, j - 1];
            //        temp[0] = tmp1;
            //        temp[1] = tmp4;
            //        temp[2] = tmp7;
            //        temp[3] = tmp8;

            //    } while (map[i, j] != 'X' && tmp1 != ship && tmp2 != ship && tmp3 != ship && tmp4 != ship && tmp5 != ship && tmp6 != ship && tmp7 != ship && tmp8 != ship);
            //    map[i, j] = 'X';

            //    tmp1 = map[i + 1, j];
            //    tmp2 = map[i + 1, j + 1];
            //    tmp3 = map[i + 1, j - 1];
            //    tmp4 = map[i - 1, j];
            //    tmp5 = map[i - 1, j + 1];
            //    tmp6 = map[i - 1, j - 1];
            //    tmp7 = map[i, j + 1];
            //    tmp8 = map[i, j - 1];
            //    temp[0] = tmp1;
            //    temp[1] = tmp4;
            //    temp[2] = tmp7;
            //    temp[3] = tmp8;
            //    int l = 0;

            //    while (tmp1 != ship && tmp2 != ship && tmp3 != ship && tmp4 != ship && tmp5 != ship && tmp6 != ship && tmp7 != ship && tmp8 != ship)
            //    {

            //    }   

        }

    }
}
