using HomeWorkGB.Core;
using HomeWorkGB.Core.Geometry;

namespace HomeWorkGB
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadKey();
        }

        static void Task1()
        {
            Logger log = new ConsoleLogger();
            log.ShowMessage("Задание №1");
            BankAccount account1 = new(600, TypeAccount.Дебетовый);
            BankAccount account2 = new(400, TypeAccount.Дебетовый);
            BankAccount account3 = new(400, TypeAccount.Кредитный);
            log.ShowMessage($"Вывод объекта account1 в строку - '{account1}'");
            log.ShowMessage($"Вывод объекта account2 в строку - '{account2}'");
            log.ShowMessage($"Вывод объекта account2 в строку - '{account3}'");
            log.ShowMessage($"Сравним счета 1 и 2 методом Equals - {account1.Equals(account2)}");
            log.ShowMessage($"Сравним счета операторами: account1 == account2 - {account1 == account2},   account2 != account 3 - {account2 != account3} ");
            log.ShowMessage($"Посмотрим HashCode наших объектов: acсount1 - {account1.GetHashCode()}, acсount2 - {account2.GetHashCode()}, acсount3 - {account3.GetHashCode()}");
        }

        static void Task2()
        {
            Logger log = new ConsoleLogger();
            log.ShowMessage("Задание №2");

            Point point = new();
            Circle circle = new(Status.Видимый,ConsoleColor.Red,3,4,2.5);
            Rectangle rectangle = new(Status.Видимый,ConsoleColor.Yellow,4,5,3,7);

            log.ShowMessage("Создаем точку с параметрами по-умолчанию, круг и прямоугольник с заданными параметрами:");

            point.GetInfo();
            circle.GetInfo();
            rectangle.GetInfo();

            point.MoveVertical(3);
            point.MoveGorizont(-1);
            point.Color = ConsoleColor.Green;

            circle.MoveVertical(3);
            circle.MoveGorizont(-1);
            circle.Color = ConsoleColor.Green;

            rectangle.MoveVertical(3);
            rectangle.MoveGorizont(-1);
            rectangle.Color = ConsoleColor.Green;

            log.ShowMessage("");
            log.ShowMessage("Сдвигаем все фигуры на 3 пункта по вертикали, -1 пункт по горизонтали и устанавливаем зелёный цвет ");

            point.GetInfo();
            circle.GetInfo();
            rectangle.GetInfo();


        }
    }
}