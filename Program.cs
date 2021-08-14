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
            Cross.InitField();
            Cross.PrintField();
            do
            {
                Cross.PlayerMove();
                Console.WriteLine("Ваш ход на поле");
                Cross.PrintField();
                if (Cross.CheckWIn(Cross.PLAYER_DOT,3))
                {
                    Console.WriteLine("Вы выиграли!");
                    break;
                }
                else if (Cross.IsFieldFull()) break;
                Cross.AiMove();
                Console.WriteLine("Ход компьютера на поле");
                Cross.PrintField();
                if (Cross.CheckWIn(Cross.AI_DOT,3))
                {
                    Console.WriteLine("Выиграл компьютер!");
                    break;
                }
                else if (Cross.IsFieldFull()) break;
                Cross.NextMove();
            } while (true);
            Console.WriteLine("Конец игры!");
        }
    }
}
