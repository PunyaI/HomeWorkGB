using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Task3
    {
        enum Seasons
        {
            Winter=1,
            Spring,
            Summer,
            Autumn
        }
        static void main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n<1 || n>12)                                      //проверка на корректность номера месяца
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int sNum = SeasonNumber(n);
            string season = Season(sNum);
            Console.WriteLine($"Это {season}!");
        }
      
        static int SeasonNumber(int n)       //метод преобразующий номер месяца в номер времени года
        {
            int season = (int)Seasons.Autumn;
            if (n == 12 || n ==1 || n == 2 )
            {
                season = (int)Seasons.Winter;
            } else if (n == 3 || n == 4 || n == 5)
            {
               season = (int)Seasons.Spring;
            }
            else if (n == 6 || n == 7 || n == 8)
            {
                season = (int)Seasons.Summer;
            }
            return season;
        }
        static string Season(int seasonNumber)  //метод преобразующий номер времени года в его название
        {
            string season = " ";
            switch (seasonNumber)
            {
                case 1:
                    season = "зима";
                    break;
                case 2:
                    season = "весна";
                    break;
                case 3:
                    season = "лето";
                    break;
                case 4:
                    season = "осень";
                    break;
            }
            return season;
        }
    }
}

