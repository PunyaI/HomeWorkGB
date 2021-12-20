using HomeWorkGeekBrains;

namespace HomeWorkGB
{
     class BankAccountTask5 : BankAccountTask4
    {

        public BankAccountTask5(decimal balance, TypeAccount type, int number):base(balance, type, number){ }

        public void PutMoney(decimal value)
        {
            Balance += value;
            Console.WriteLine($"Пополнение счёта на {value} у.е. прошло успешно. Ваш баланс: {Balance} у.е.");
        }
        public void TakeMoney(decimal value)
        {
            if (Balance < value)
            {
                Console.WriteLine("Ошибка! Недостаточно средств на счёте!");
            }
            else
            {
                Balance -= value;
                Console.WriteLine($"Снятие денег со счёта на сумму {value} у.е. прошло успешно. Ваш остаток на балансе: {Balance} у.е.");
            }
        }

    }
}
