using HomeWorkGB;

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

            //Задание №1
            Console.WriteLine("Задание №1");
            BankAccountTask1 bank = new();
            bank.SetNumber(333);
            bank.SetBalance(2000);
            bank.SetType(TypeAccount.Дебетовый);
            bank.GetInfo();
            Console.WriteLine();
            Console.WriteLine();


            //Задание №2
            Console.WriteLine("Задание №2");
            BankAccountTask2 bank2 = new();
            BankAccountTask2 bank22 = new();
            bank2.SetNumber();
            bank22.SetNumber();
            bank2.SetBalance(2000);
            bank2.SetType(TypeAccount.Дебетовый);
            bank2.GetInfo();
            bank22.GetInfo();
            Console.WriteLine();
            Console.WriteLine();

            //Задание №3
            Console.WriteLine("Задание №3");
            BankAccountTask3 bank3 = new();
            BankAccountTask3 bank33 = new(5000);
            BankAccountTask3 bank333 = new(TypeAccount.Дебетовый);
            BankAccountTask3 bank3333 = new(7600, TypeAccount.Кредитовый);
            Console.WriteLine("Конструктор по-умолчанию");
            bank3.GetInfo();
            Console.WriteLine("Конструктор с 1 аргументом decimal");
            bank33.GetInfo();
            Console.WriteLine("Конструктор с 1 аргументом TypeAccount");
            bank333.GetInfo();
            Console.WriteLine("Конструктор с 2 аргументами: decimal и TypeAccount");
            bank3333.GetInfo();
            Console.WriteLine();
            Console.WriteLine();

            //Задание №4
            Console.WriteLine("Задание №4");
            BankAccountTask4 bank4 = new(7200, TypeAccount.Дебетовый);
            Console.WriteLine("Конструктор с 2 аргументами: decimal и TypeAccount");
            bank4.GetInfo();
            bank4.Number = 555;
            bank4.Type = TypeAccount.Инвестиционный;
            bank4.Balance = 12430;
            Console.WriteLine("Изменили через свойство: номер -  на 555, тип - на Инвестиционный и баланс  - на 12430");
            bank4.GetInfo();
            Console.WriteLine();
            Console.WriteLine();

            //Задание №5
            Console.WriteLine("Задание №5");
            BankAccountTask5 bank5 = new(200, TypeAccount.Дебетовый, 55);
            bank5.GetInfo();
            Console.WriteLine("Cнять 300 у.е.");
            bank5.TakeMoney(300);
            Console.WriteLine("Положить 150 у.е.");
            bank5.PutMoney(150);
            Console.WriteLine("Cнять 300 у.е.");
            bank5.TakeMoney(300);

            Console.ReadKey();

        }
    }
}