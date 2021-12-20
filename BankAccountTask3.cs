using HomeWorkGeekBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGB
{
    class BankAccountTask3 : BankAccountTask2
    {
        private static int _lastNumber = 0;

        public BankAccountTask3() : this(0, TypeAccount.Не_определен){}
        public BankAccountTask3(decimal balance) : this(balance, TypeAccount.Не_определен) { }
        public BankAccountTask3(TypeAccount type) : this(0, type) { }
        public BankAccountTask3(decimal balance, TypeAccount type)
        {
            SetNumber();
            _balance = balance;
            _type = type;
        }
        public override void SetNumber()
        {
            _number = _lastNumber + 1;
            _lastNumber = _number;
        }
    }
}
