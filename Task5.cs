using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Task5
    {
        static void main(string[] args)
        {
            string str1 = " Предложение один Теперь предложение два Предложение три";
            Dots(str1);
        }
        static void Dots(string str)
        {
            string[] words = str.Split(' ');
            string res = words[1] + " " + words[2] + ". " + words[3] + " " + words[4] + " " + words[5] + ". " + words[6] + " " + words[7] + ". ";
            Console.WriteLine(res);
        }
    }
}

