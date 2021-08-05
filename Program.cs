using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;



namespace HomeWorkGeekBrains
{

    class Program
    {
        
        static void Main(string[] args)
        {


            //Задание №1

            Console.WriteLine("Введите данные для записи");
            File.WriteAllText("task1.txt", Console.ReadLine());

            Console.WriteLine("Вы записали в файл:");
            Console.WriteLine(File.ReadAllText("task1.txt"));



            //Задание №2

            string filename2 = "startup.txt";
            DateTime now = DateTime.Now;
            File.AppendAllText(filename2, now.ToString("F"));
            File.AppendAllText(filename2, Environment.NewLine);

            Console.WriteLine();
            Console.WriteLine("История запусков программы:");
            Console.WriteLine(File.ReadAllText(filename2));

            //Задание №3

            Console.WriteLine();
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255 через пробел");
            File.WriteAllBytes("bytes.bin", ConvToBytes());

            Console.WriteLine("Вы записали в файл:");
            byte[] fromfile = File.ReadAllBytes("bytes.bin");
            foreach (var item in fromfile)
            {
                Console.Write(" " + item);
            }


            //Задание №4
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine();
            Person[] persArray = new Person[5];
            persArray[0] = new Person("Петров Андрей Сергеевич", "заместитель директора", "petrov1980@mail.ru", 89932345321, 65_500, 41);
            persArray[1] = new Person("Кузнецов Евгений Викторович", "инженер", "evgen007@gmail.ru", 89632541723, 42_300, 31);
            persArray[2] = new Person("Ганин Сергей Евгеньевич", "генеральный директор", "ganin1965@mail.ru", 89982328724, 123_700, 56);
            persArray[3] = new Person("Павлова Ольга Петровна", "бухгалтер", "ole4ka@mail.ru", 89982965351, 44_800, 47);
            persArray[4] = new Person("Войтенко Юлия Андреевна", "менеджер по продажам", "yulia.voitenko@mail.ru", 89968875522, 34_400, 23);
            for (int i = 0; i < persArray.Length; i++)
            {
                if (persArray[i].age >= 40)
                {
                    persArray[i].Info();
                }
            }

        }
        static byte[] ConvToBytes()
        {
            string source = Console.ReadLine();

            for (int i = 0; i < source.Length; i++)                         //этот цикл проверяет нет действительно ли в строке только положительные числа
            {
                if (source[i] > '9' || source[i] < '0' && source[i] != ' ')
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку:");
                    source = Console.ReadLine();
                    i = 0;
                }
            }
            string[] num = source.Split();                               //тут проверяем нет ли чисел больше, чем 255, если есть, то приводим к 255, как максимальному значению byte
            byte[] data3 = new byte[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                int check = Convert.ToInt32(num[i]);
                if (check > 255)
                {
                    Console.WriteLine($"Число {num[i]} больше 255, поэтому будет приведено к 255");
                    check = 255;
                }
                data3[i] = Convert.ToByte(check);
            }

            return data3;
        }

        class Person
        {
            public string fullname { get; set; }
            public string position { get; set; }
            public string email { get; set; }
            public long phone { get; set; }
            public float wage { get; set; }
            public int age { get; set; }

            public Person()
            {
            }
            public Person(string fullname, string position, string email, long phone, float wage, int age)
            {
                this.fullname = fullname;
                this.position = position;
                this.email = email;
                this.phone = phone;
                this.wage = wage;
                this.age = age;
            }
            public void Info()
            {
                Console.WriteLine();
                Console.WriteLine($"              ФИО:  {fullname}");
                Console.WriteLine($"        Должность:  {position}");
                Console.WriteLine($"            Email:  {email}");
                Console.WriteLine($"   Номер телефона:  {phone:# (###) ###-##-##}");
                Console.WriteLine($" Заработная плата:  {wage:c0}");
                Console.WriteLine($"          Возраст:  {age} лет");
                Console.WriteLine();
            }
        }
    }
}
