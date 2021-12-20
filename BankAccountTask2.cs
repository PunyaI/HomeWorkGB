using HomeWorkGeekBrains;

namespace HomeWorkGB
{
     class BankAccountTask2: BankAccountTask1
    {
        private static int _lastNumber = 0;

        public virtual void SetNumber()
        {
            _number =_lastNumber + 1;
            _lastNumber =_number;
        }

    }
}
