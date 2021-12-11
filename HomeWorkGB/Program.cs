using HomeWorkGB.Core;

namespace HomeWorkGB
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = new ConsoleLogger();

            Rational num1 = new();
            Rational num2 = new(3, 2);
            Rational num3 = new(6, 4);
            Rational num4 = new(7,3);

            bool j = num4 != num2;
            log.ShowMessage($"Вывод объектов в строку: num1 - {num1.ToString()}, num2 - {num2.ToString()}, num3 - {num3.ToString()}, num4 - {num4.ToString()}");
            log.ShowMessage($"Сравнение методом Equals: {num1} и {num2} - {num1.Equals(num2)}, числа {num2}  и {num3} - {num2.Equals(num3)}");
            log.ShowMessage($"Сравнение операторами: {num2} == {num3} - {num2 == num3}, {num2} != {num3} - {num2 != num3}, {num2} > {num1} - {num2 > num1}, {num4} < {num3} - {num4 < num3}");
            log.ShowMessage($"{num3} >= {num2} - {num3 >= num2}, {num4} <= {num2} - {num4 <= num2}, {num4} != {num1} - {num4 != num1}");
            log.ShowMessage($"HashCode: Число по умолчанию {num1.GetHashCode()}, число {num2} {num2.GetHashCode()}, число {num3} {num3.GetHashCode()}, {num4} {num4.GetHashCode()}");
            log.ShowMessage($"Преобразуем объект num3 ({num3}) в float  - {(float)num3}, а теперь в int - {(int)num3}");
            log.ShowMessage($"Проверим операторы сложения, вычитания и инкремента: {num2} + {num1} = {num2 + num1}, {num3} - {num2} = {num3 - num2}, num1++ = {num1++}, num1-- = {num1--}");
            log.ShowMessage($"Операторы умножения, деления и остатка от деления: {num4} * {num2} = {num4 * num2}, {num3} / {num2} = {num3 / num2}, {num4} % {num2} = {num4 % num2} ");
            
            Console.ReadKey();
        }
    }
}