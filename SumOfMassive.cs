using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeekBrains
{
    class SumOfMassive
    {
        private string[,] masiv;
        public string[,] mas
        {
            get { return masiv; }
            set
            {
                if (mas.GetLength(0) != 4 || mas.GetLength(1) != 4)
                {
                    throw new MyArraySizeException("Неверная размерность массива, должен быть 4 на 4");
                }
                else
                {
                    masiv = mas;
                } 
                    
            }
        }
        public int SumOfMassivee(string[,] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    int value = Convert.ToInt32(mas[i, j]);
                    sum += value;
                }

            }
            return sum;
        }
    }
}
