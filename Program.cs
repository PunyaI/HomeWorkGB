using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HomeWorkGeekBrains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Задание №1");
            Console.WriteLine();
            

            GetProcessesList();
            while (true)
            {
                Console.WriteLine(" Введите:");
                Console.WriteLine(" Название процесса или его ID, чтобы завершить процесс или End, чтобы выйти из программы");
                Console.WriteLine(" 'Обновить', чтобы обновить список процессов");
                Console.WriteLine(" 'Выйти', чтобы выйти из программы");
                string nameOrId = Console.ReadLine();
                if (nameOrId == "Выйти" || nameOrId == "выйти")
                {
                    break;
                }
                else if (nameOrId == "Обновить" || nameOrId == "обновить")
                {
                    Console.Clear();
                    GetProcessesList();
                }
                else
                {
                    KillProcess(nameOrId);
                }
            }







            Console.WriteLine();
            Console.WriteLine("Задание №2");
            Console.WriteLine();


            string[,] massa =  { { "2", "d", "6", "8" },           //инициализируем начальный массив с 2 некорректными ячейками
                                 { "5", "s", "4", "5" },
                                 { "5", "6", "4", "5" },
                                 { "2", "4", "6", "8" }};
            bool flag = true;
            while (flag)                                //цикл на флагах, обрабатываем исключение, меняем либо значение элемента
            {                                           //либо сам массив и возвращаемся в try, пока не исправим все исключения
                try
                {
                    Massive.WriteSumOfMassive(massa);
                    flag = false;
                }
                catch (MyArraySizeException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine("Заполните новый массив 4x4");    
                    int[,] mas = Massive.ReadMassive4x4();      //создаем новый массив и с помощью метода заполняем его
                    Massive.WriteSumOfMassive(mas);
                    flag = false;
                }
                catch (MyArrayDataException ex)
                {
                    Console.WriteLine($"{ex.Message} {ex.x}, {ex.y}");
                    Console.WriteLine("Введите корректное численное значение");
                    massa[ex.x, ex.y] = Console.ReadLine();       
                    flag = true;
                }
            }
                
        }
           





        static void GetProcessesList()
        {
            Console.SetCursorPosition(0, 3);
            Process[] list = Process.GetProcesses();
            Console.WriteLine("  ID      Имя процесса                       Использование памяти");
            Console.WriteLine();
            for (int i = 0; i < list.Length; i++)
            {
                Console.SetCursorPosition(0, i + 5);
                Console.Write("  " + list[i].Id);
                Console.SetCursorPosition(10, i + 5);
                Console.Write(" " + list[i].ProcessName);
                Console.SetCursorPosition(45, i + 5);
                Console.Write($" {list[i].WorkingSet64 / (1024 * 1024):f2}");
                Console.SetCursorPosition(53, i + 5);
                Console.WriteLine(" МБ ");
            }
            Console.WriteLine();
        }
        static void KillProcess(string procname)
        {
            Process[] list = Process.GetProcesses();
            bool flag = true;                                    //флаг проверки корректности введенных данных
            if (IsID(procname))                                  //Проверяем ввели ID или же имя процесса
            {
                
                try                                             //если ID, то обрабатываем исключение, если ввели слишком длинное число за пределами int
                {
                    int id = Convert.ToInt32(procname);
                    for (int i = 0; i < list.Length; i++)        //находим наш процесс по ID и убиваем. снимаем флаг
                    {
                        if (list[i].Id == id)                            
                        {
                            list[i].Kill();
                            Console.WriteLine($"Процесс c ID '{list[i].Id}' убит");
                            Console.WriteLine();
                            flag = false;
                        }
                    }
                    if (flag)                                            //обрабатываем флаг
                    {
                        Console.WriteLine("Ошибка! Данный процесс не найден!");
                        Console.WriteLine();
                    }
                }
                catch                                                  
                {
                    Console.WriteLine("Ошибка! Некорректный ввод!");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < list.Length; i++)                 //если ввели имя, то сразу ищем по имени среди всех процессов и меняем флаг, если нашли
                {
                    if (list[i].ProcessName == procname)
                    {
                        list[i].Kill();
                        Console.WriteLine($"Процесс '{list[i].ProcessName}' убит");
                        Console.WriteLine();
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Ошибка! Данный процесс не найден!");
                    Console.WriteLine();
                }
            }

        }
        static bool IsID(string source)                   //проверяем что ввел пользователь - текст или число (ID)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < '0' || source[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
