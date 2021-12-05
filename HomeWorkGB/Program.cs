

using HomeWorkGB.Core;

namespace HomeWorkGeekBrains
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = new ConsoleLogger();
            Building building1 = Сreator.CreateBuild();
            Building building2 = Сreator.CreateBuild(28, 4, 4, 5);
            building1.Info();
            building2.Info();
            
            building1.Apartments = 120;
            building1.Floor = 5;
            building1.High = 15;
            building1.Entrances = 6;

            building1.Info();

            building1.GetFloorHigh();
            building1.GetApartmentsPerEntrances();
            building1.GetApartmentsPerFloor();

            log.ShowMessage("");
            log.ShowMessage($"Всего создано объектов: {Сreator.Buildings.Count.ToString()}");
            log.ShowMessage("Пробуем удалить из хеш таблицы дом с номером 25");
            Сreator.DeleteBuild(25);
            log.ShowMessage($"Всего создано объектов: {Сreator.Buildings.Count.ToString()}");
            log.ShowMessage("Пробуем удалить из хеш таблицы дом с номером 2");
            Сreator.DeleteBuild(2);
            log.ShowMessage($"Всего создано объектов: {Сreator.Buildings.Count.ToString()}");
            log.ShowMessage("Выводим инфо об объекте дома с номером 2, который мы удалили из хеш таблицы");
            building2.Info();
            System.Console.ReadKey();

        }
    }
}