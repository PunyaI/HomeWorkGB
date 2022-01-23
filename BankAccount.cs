

using HomeWorkGeekBrains;

namespace HomeWorkGB
{
    class BankAccount
    {
        private static int _lastNumber = 0;

        private int _number;
        private decimal _balance;
        private TypeAccount _type;

        public int Number 
        {
            get 
            { 
                return _number; 
            }
            set 
            {
                if (value <= _lastNumber)              //если номер уже использовался, то выдаем номер по порядку, если нет - назначаем введенный пользователем.
                {                                      //но тут номера могут повториться, когда счетчик дойдет до введенного вручную, для обхода
                    _number = _lastNumber + 1;         //можно было бы использовать либо сохранение введенных вручную номеров в массиве,
                    _lastNumber = _number;              // либо хранить все номера в HashSet, т.к. он хранит только уникальные значения                
                }
                else
                {
                    _number = value;
                }
            } 
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public TypeAccount Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public BankAccount() : this(0, TypeAccount.Не_определен, 0) { }
        public BankAccount(decimal balance) : this(balance, TypeAccount.Не_определен, 0) { }
        public BankAccount(TypeAccount type) : this(0, type, 0) { }
        public BankAccount(int number) : this(0, TypeAccount.Не_определен, number) { }
        public BankAccount(decimal balance, TypeAccount type) : this(balance, type, 0) { }
        public BankAccount(decimal balance, TypeAccount type, int number)
        {
            Number = number;
            Balance = balance;
            Type = type;
        }
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
        public void Transaction (BankAccount sender, decimal sum)
        {
            if(sender.Balance>=sum)
            {
                sender.Balance -= sum;
                Balance += sum;
                Console.WriteLine($"Перевод средств произведен успешно. На Ваш счёт поступило {sum} у.е. Текущий баланс: {Balance} у.е.");
            } else
            {
                Console.WriteLine("Ошибка! Недостаточно средств на счёте отправителя.");
            }
            
        }
        public void GetInfo()
        {
            Console.WriteLine("Номер банковского счёта: " + Number);
            Console.WriteLine("Баланс банковского счёта: " + Balance);
            Console.WriteLine("Тип банковского счёта: " + Type);
            Console.WriteLine();
        }
    }
}
