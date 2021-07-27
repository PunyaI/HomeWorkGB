using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Program
    {
        [Flags]
        enum Week
        {
            Понедельник = 0b_0000001,
            Вторник     = 0b_0000010,
            Среда       = 0b_0000100,
            Четверг     = 0b_0001000,
            Пятница     = 0b_0010000,
            Суббота     = 0b_0100000,
            Воскресенье = 0b_1000000
        }

        static void Main(string[] args)
        {
            ////Задание №1
            //Console.WriteLine("Какая сегодня была минимальная температура?");
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Какая сегодня была максимальная температура?");
            //int max = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Среднесуточная температура сегодня - {(min + max) / 2} градусов.");
            //Console.ReadKey();






            ////Задание №2

            //Console.WriteLine("Введите номер месяца");
            //int n = Convert.ToInt32(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("Январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("Февраль");
            //        break;
            //    case 3:
            //        Console.WriteLine("Март");
            //        break;
            //    case 4:
            //        Console.WriteLine("Апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("Май");
            //        break;
            //    case 6:
            //        Console.WriteLine("Июнь");
            //        break;
            //    case 7:
            //        Console.WriteLine("Июль");
            //        break;
            //    case 8:
            //        Console.WriteLine("Август");
            //        break;
            //    case 9:
            //        Console.WriteLine("Сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("Октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("Ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("Декабрь");
            //        break;
            //    default:
            //        Console.WriteLine("Значение должно быть от 1 до 12 включительно");
            //        break;
            //}






            ////Задание №3
            //Console.WriteLine("Введите число");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Число чётное");
            //}
            //else
            //{
            //    Console.WriteLine("Число нечётное");
            //}






            ////Задание №4

            //string dline = "=========================================";
            //string line = "-----------------------------------------";
            //string welcome = "ДОБРО ПОЖАЛОВАТЬ!";
            //string cashcheck = "КАССОВЫЙ ЧЕК";
            //string come = "ПРИХОД";
            //string check = "ЧЕК";
            //char N = '№';
            //int checkN = 7;
            //DateTime date = new DateTime(2018, 6, 20, 12, 32, 0);
            //string dish = "Котлета куриная";
            //double kol = 2.000;
            //char x = 'x';
            //double price = 70.00;
            //char ravno = '=';
            //double sum = 140.00;
            //string end = "ИТОГ";
            //Console.WriteLine($"{dline}");
            //Console.WriteLine($"            {welcome}");
            //Console.WriteLine($"              {cashcheck}");
            //Console.WriteLine($"{come}                  ");
            //Console.WriteLine($"{check} {N}{checkN}                    {date.ToString("dd.MM.yy HH:mm")}");
            //Console.WriteLine($"{line}");
            //Console.WriteLine($"{dish}");
            //Console.WriteLine($"                    {string.Format("{0:0.00}", kol)} {x} {string.Format("{0:0.00}", price)} {ravno}{string.Format("{0:0.00}", sum)}");
            //Console.WriteLine($"{line}");
            //Console.WriteLine($"{end}                             {ravno}{string.Format("{0:0.00}", sum)}");
            //Console.WriteLine($"{dline}");
            //Console.ReadKey();





            ////Задание №5

            //bool IsWinter = false;
            //Console.WriteLine("Какая сегодня была минимальная температура?");
            //int minim = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Какая сегодня была максимальная температура?");
            //int maxim = Convert.ToInt32(Console.ReadLine());
            //float mid = (minim + maxim) / 2;
            //Console.WriteLine("Введите номер месяца");
            //int num = Convert.ToInt32(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("Февраль");
            //        break;
            //    case 3:
            //        Console.WriteLine("Март");
            //        break;
            //    case 4:
            //        Console.WriteLine("Апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("Май");
            //        break;
            //    case 6:
            //        Console.WriteLine("Июнь");
            //        break;
            //    case 7:
            //        Console.WriteLine("Июль");
            //        break;
            //    case 8:
            //        Console.WriteLine("Август");
            //        break;
            //    case 9:
            //        Console.WriteLine("Сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("Октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("Ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("Декабрь");
            //        break;
            //    default:
            //        Console.WriteLine("Значение должно быть от 1 до 12 включительно");
            //        break;
            //}
            //if (num == 12 || num == 1 || num == 2)     //Проверка на зимние месяцы
            //{
            //    IsWinter = true;
            //}
            //if (mid > 0 && IsWinter)
            //{
            //    Console.WriteLine("Какая дождливая зима!");
            //}

            //Console.ReadKey();







            ////Задание №6

            //Week classic = Week.Понедельник | Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница;
            //Week office1 = Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница;
            //Week office2 = (Week)0b1111111;
            //Console.WriteLine("Классическая рабочая неделя выглядит так:");
            //Console.WriteLine($"{classic}");
            //Console.WriteLine();
            //Console.WriteLine("Рабочая неделя в офисе №1:");
            //Console.WriteLine($"{office1}");
            //Console.WriteLine();
            //Console.WriteLine("Рабочая неделя в офисе №2:");
            //Console.WriteLine($"{office2}");
            //Console.ReadKey();

        }

    }
}
