using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class Cross
    {
        static int SYZE_Y = 3;
        static int SYZE_X = 3;
        public static int SYZE_WIN = 3;

        private static int MOVE = 1;

        static char[,] field = new char[SYZE_Y, SYZE_X];

        public static char PLAYER_DOT = 'X';
        public static char AI_DOT = '0';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        public static void NextMove()
        {
            MOVE++;
        }
        public static void InitField()
        {
            for (int i = 0; i < SYZE_Y; i++)
            {
                for (int j = 0; j < SYZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        public static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("----------");
            for (int i = 0; i < SYZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SYZE_X; j++)
                {
                    Console.Write(field[i,j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------");
        }

        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y <0 || x > SYZE_X - 1 || y > SYZE_Y - 1)
            {
                return false;
            }
            return field[y, x] == EMPTY_DOT;
        }

        public static bool IsFieldFull()
        {
            for (int i = 0; i < SYZE_Y; i++)
            {
                for (int j = 0; j < SYZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void PlayerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Координата по строке");
                Console.WriteLine("Введите координату вашего хода в диапазоне от 1 до " + SYZE_Y);
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координата по столбцу");
                Console.WriteLine("Введите координату вашего хода в диапазоне от 1 до " + SYZE_X);
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        public static void AiMove()
        { 
            int x, y;
           
                if (MOVE == 1)                         //в первый ход занимаем центр или свободный угол
                {
                    if (field[SYZE_Y / 2, SYZE_X / 2] == EMPTY_DOT)
                    {

                        x = SYZE_X / 2;
                        y = SYZE_Y / 2;
                        SetSym(y, x, AI_DOT);
                    }
                     else if (field[0, 0] == EMPTY_DOT)
                    {
                        x = 0;
                        y = 0;
                        SetSym(y, x, AI_DOT);
                    }
                    else if (field[0, SYZE_X - 1] == EMPTY_DOT)
                    {
                        x = SYZE_X;
                        y = 0;
                        SetSym(y, x, AI_DOT);
                    }
                    else if (field[SYZE_Y - 1, 0] == EMPTY_DOT)
                    {
                        x = 0;
                        y = SYZE_Y;
                        SetSym(y, x, AI_DOT);
                    }
                    else if (field[SYZE_Y - 1, SYZE_X - 1] == EMPTY_DOT)
                    {
                        x = SYZE_X;
                        y = SYZE_Y;
                        SetSym(y, x, AI_DOT);
                    }
                }
            else
            {
                if (!AI_CHECK(3,AI_DOT))                                 //проверяем можем ли выиграть сейчас
                {
                    if (!AI_CHECK(3, PLAYER_DOT))                       //проверяем не выигрывает ли следующим ходом игрок
                    {
                        if (!AI_CHECK(2, AI_DOT))                       //пытаемся собрать 2 в ряд
                        {
                            x = random.Next(0, SYZE_X - 1);              // если даже 2 не получается, ходим случайным образом
                            y = random.Next(0, SYZE_Y - 1);
                            SetSym(y, x, AI_DOT);
                        }
                    }    
                }
            }
        }

        private static bool AI_CHECK(int syze_win, char sym)
        {
            for (int i = 0; i < SYZE_Y; i++)
            {
                for (int j = 0; j < SYZE_X; j++)
                {
                    if (IsCellValid(i, j))
                    {
                        char temp = field[i, j];
                        SetSym(i, j, sym);
                        if (CheckWIn(sym, syze_win))
                        {
                            SetSym(i, j, AI_DOT);
                            return true;
                        }
                        else
                        {
                            SetSym(i, j, temp);
                        }
                    }
                }
                
            }
            return false;
        }
        public static bool CheckWIn(char sym, int syze_win)
        {
            SYZE_WIN = syze_win;
            int flag = 0;
            int flag1 = 0;
            int flag2 = 0;
            int i;
            //проверки на окончание игры по столбцам, строкам, главной диагонали и диагоналей выше и ниже главной
            for (i = 0; i < SYZE_Y; i++)
            {
                for (int j = 0; j < SYZE_X; j++)
                {
                    if (sym == field[i, j])         // проверка столбцов
                    {
                        flag++;
                    }
                    if (sym == field[j, i])        //проверка строк
                    {
                        flag1++;
                    }
                    if (flag == SYZE_WIN || flag1 == SYZE_WIN)
                    {
                        return true;
                    }
                }
                flag = 0;
                flag1 = 0;
            }
                flag = 0;
                flag1 = 0;
                i = 0;
                for (int j = 0; j < SYZE_X; j++)
                { 
                    if (field[i, j] == sym)             //проверки главной диагонали и диагоналей параллельных ей выше и ниже
                    {
                        flag++;
                    }
                    if (j < SYZE_WIN - 1)
                    {
                        if (field[i, j + 1] == sym)
                        {
                            flag1++;
                        }
                        if (field[i + 1, j] == sym)
                        {
                            flag2++;
                        }
                    }
                    i++;
                    if (flag == SYZE_WIN || flag1 == SYZE_WIN || flag2 == SYZE_WIN)
                    {
                       return true;
                    }
                }
                flag = 0;
                flag1 = 0;
                flag2 = 0;
                i = 0;
                for (int j = SYZE_X - 1; j >= 0; j--)
                {
                    if (field[i, j] == sym)             //проверки побочной диагонали и диагоналей параллельных ей выше и ниже
                    {
                        flag++;
                    }
                    if (j < SYZE_WIN - 1 && j > 0)
                    {
                        if (field[i, j - 1] == sym)
                        {
                            flag1++;
                        }
                        if (field[i + 1, j] == sym)
                        {
                            flag2++;
                        }
                    }
                    i++;
                    if (flag == SYZE_WIN || flag1 == SYZE_WIN || flag2 == SYZE_WIN)
                        {
                            return true;
                        }
                 }
            return false;
        }
    }
}
