

using HomeWorkGeekBrains;

namespace HomeWorkGB
{
    class BankAccountTask4
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
        public BankAccountTask4() : this(0, TypeAccount.Не_определен, 0) { }
        public BankAccountTask4(decimal balance) : this(balance, TypeAccount.Не_определен, 0) { }
        public BankAccountTask4(TypeAccount type) : this(0, type, 0) { }
        public BankAccountTask4(int number) : this(0, TypeAccount.Не_определен, number) { }
        public BankAccountTask4(decimal balance, TypeAccount type) : this(balance, type, 0) { }
        public BankAccountTask4(decimal balance, TypeAccount type, int number)
        {
            Number = number;
            Balance = balance;
            Type = type;
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
