using HomeWorkGB;
using System.Diagnostics;
using System.Text;

namespace HomeWorkGeekBrains
{
    public enum TypeAccount
    {
        Дебетовый = 1,
        Кредитовый = 2,
        Инвестиционный = 3,
        Не_определен = 0
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();


        }
        static string ReverseString(string source)
        {
            StringBuilder temp = new StringBuilder(source.Length);
            for (int i = source.Length - 1; i >=0; i--)
            {
                temp.Append(source[i]);
            }
            return temp.ToString(); 
        }
        static string ReverseStringFast(string source)
        {
            char[] array = source.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Task1()
        {
            Console.WriteLine("Задание №1");
            Console.WriteLine();
            BankAccount accountSender = new(600, TypeAccount.Дебетовый);
            BankAccount accountPayee = new(TypeAccount.Дебетовый);
            Console.WriteLine("Инфо о счёте отправителя");
            accountSender.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Инфо о счёте получателя");
            accountPayee.GetInfo();
            Console.WriteLine("Переводим 700 у.е. с первого аккаунта, на второй.");
            accountPayee.Transaction(accountSender, 700);
            Console.WriteLine("Инфо о счёте отправителя");
            accountSender.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Инфо о счёте получателя");
            accountPayee.GetInfo();
            Console.WriteLine("Как видим средств было недостаточно для перевода, балансы счетов не изменились");
            Console.WriteLine("Переводим 400 у.е. с первого аккаунта, на второй.");
            accountPayee.Transaction(accountSender, 400);
            Console.WriteLine("Инфо о счёте отправителя");
            accountSender.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Инфо о счёте получателя");
            accountPayee.GetInfo();
            Console.WriteLine("Теперь же всё отработало корректно");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2");
            Console.WriteLine();
            string exampleShort = "123456789";
            char[] temp = new char[5000];
            Random random = new Random();
            for (int i = 0; i < 5000; i++)
            {
                temp[i] += (char)random.Next(0, 127);
            }
            string exampleLong = new string(temp);
            Console.WriteLine("Проверяем на короткой строке корректности работы алгоритмов");
            Console.WriteLine();
            Console.WriteLine("Исходная строка: " + exampleShort);
            Console.WriteLine("Переворот через StringBuilder (или просто string): " + ReverseString(exampleShort));
            Console.WriteLine("Переворот через массив символов: " + ReverseStringFast(exampleShort));
            Console.WriteLine();
            Console.WriteLine("Оба варианта переворачивают корректно. Теперь замеряем производительность на короткой и длинной строке (5000 символов)");
            Console.WriteLine();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ReverseString(exampleShort);
            timer.Stop();
            Console.WriteLine($"Короткая строка через StringBuilder:     {timer.Elapsed} ");
            timer.Restart();
            ReverseStringFast(exampleShort);
            timer.Stop();
            Console.WriteLine($"Короткая строка через массив символов:   {timer.Elapsed} ");
            Console.WriteLine();
            timer.Restart();
            ReverseString(exampleLong);
            timer.Stop();
            Console.WriteLine($"Длинная строка через StringBuilder:      {timer.Elapsed} ");
            timer.Restart();
            ReverseStringFast(exampleLong);
            timer.Stop();
            Console.WriteLine($"Длинная строка через массив символов:    {timer.Elapsed} ");
            Console.WriteLine();
            Console.WriteLine("Как видим даже на больших строках (для которых предназначен StringBuilder) гораздо быстрее работает алгоритм через массив символов");
        }
    }
}