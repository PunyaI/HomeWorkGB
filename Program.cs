using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine ($" Привет, {name}, сегодня {DateTime.Now}!");
        }
    }
}
