using HomeWorkGeekBrains;

namespace HomeWorkGB
{
  
     class BankAccountTask1
    {
        //Изменил с приватного на internal, чтобы можно было в след заданиях не дублировать код, а просто наследоваться от предыдущего
        internal int _number;
        internal decimal _balance;
        internal TypeAccount _type; 

        public void SetNumber(int value)
        {
            _number = value;
        }
        public int GetNumber()
        {
            return _number;
        }
        public void SetBalance(decimal value)
        {
            _balance = value;
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void SetType(TypeAccount value)
        {
            _type = value;
        }
        public TypeAccount GetTypeAccount()
        {
            return _type;
        }
        public void GetInfo()
        {
            Console.WriteLine("Номер банковского счёта: " + GetNumber());
            Console.WriteLine("Баланс банковского счёта: " + GetBalance());
            Console.WriteLine("Тип банковского счёта: " + GetTypeAccount());
            Console.WriteLine();
        }

    }
}
