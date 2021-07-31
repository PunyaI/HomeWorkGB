using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Task1
    {
       static void Main(string[] args)
        {
            bool end = false;
            while (!end)
            {
                (string firstName, string lastName, string patronymic) = AskUser();
                string fullName = GetFullName(firstName, lastName, patronymic);
                Console.WriteLine($"ФИО:  {fullName}");
                Console.WriteLine("Для продолжения нажмите 'Enter', а для выхода введите 'End'");
                end = AskEnd();                      //проверям хочет ли пользователь закончить ввод данных
            }
        }
        static bool AskEnd()                       //метод проверки хочет ли пользователь закончить ввод
        {
            bool end = false;
            string key = Console.ReadLine();
            if (key=="End")
            {
                end = true;
            } 
            return end;
        }
       static (string firstName, string lastName, string patronymic) AskUser()    //метод запроса данных пользователя
        {
            Console.Write("Введите имя ");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию ");
            string lastName = Console.ReadLine();
            Console.Write("Введите отчество ");
            string patronymic = Console.ReadLine();
            return (firstName, lastName, patronymic);
        }
        static string GetFullName(string firstName, string lastName, string patronymic)  //метод преобразующий данные пользователя в ФИО
        {
            string fullName = lastName + ' ' + firstName + ' ' + patronymic;
            return fullName;
        }
    }
}

