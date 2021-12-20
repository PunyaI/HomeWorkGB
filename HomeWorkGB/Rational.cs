using HomeWorkGB.Core;

namespace HomeWorkGB
{
    public sealed class Rational
    {
        private readonly Logger log = new ConsoleLogger();
        private int _numerator;
        private int _denominator;

        public Rational():this(0,1)
        {
        }
        public Rational(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        public int Denominator 
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                {
                    log.ShowMessage("Ошибка! Знаменатель не может быть равен нулю!");
                    _denominator = 1;
                    return;
                }
                _denominator = value;
            }
        }
        public override string ToString()
        {
            if (Numerator == 0)
                return "0";
            if (Numerator == Denominator)
                return "1";
            return $"{Numerator}/{Denominator}";
        }
        public override bool Equals(object source)
        {
            Rational num = (Rational)source;
            if (num == null)
                return false;
            if (Numerator / Denominator == num.Numerator / num.Denominator)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            if (Numerator == 0)
                return ((Numerator + 515 / Denominator) * 9990737).GetHashCode();
            return ((Numerator / Denominator) * 9990737).GetHashCode();
        }

        public static implicit operator float (Rational number)
        {
            return (float)number.Numerator / number.Denominator;
        }
        public static implicit operator int(Rational number)
        {
            return (int)number.Numerator / number.Denominator;
        }

        public static Rational operator *(Rational n1, Rational n2)
        {
            Rational result = new Rational();
            result.Numerator = n1.Numerator * n2.Numerator;
            result.Denominator = n1.Denominator * n2.Denominator;
            return result;
        }
        public static Rational operator /(Rational n1, Rational n2)
        {
            Rational result = new Rational();
            result.Numerator = n1.Numerator * n2.Denominator;
            result.Denominator = n1.Denominator * n2.Numerator;
            return result;
        }
        public static int operator %(Rational n1, Rational n2)
        {
            return (int)n1%(int)n2;
        }

        public static Rational operator +(Rational n1, Rational n2)
        {
            Rational result = new Rational();
            if (n1.Denominator==n2.Denominator)
            {
                result.Numerator = n1.Numerator + n2.Numerator;
                result.Denominator = n2.Denominator;
                return result;
            }
            result.Numerator = n1.Numerator*n2.Denominator + n2.Numerator*n1.Denominator;
            result.Denominator = n1.Denominator * n2.Denominator;
            return result;
        }
        public static Rational operator ++(Rational n1)
        {
            n1.Numerator += n1.Denominator;
            return n1;
        }
        public static Rational operator -(Rational n1, Rational n2)
        {
            Rational result = new Rational();
            if (n1.Denominator == n2.Denominator)
            {
                result.Numerator = n1.Numerator - n2.Numerator;
                result.Denominator = n2.Denominator;
                return result;
            }
            result.Numerator = n1.Numerator * n2.Denominator - n2.Numerator * n1.Denominator;
            result.Denominator = n1.Denominator * n2.Denominator;
            return result;
        }
        public static Rational operator --(Rational n1)
        {
            n1.Numerator -= n1.Denominator;
            return n1;
        }
        public static bool operator <(Rational n1, Rational n2)
        {
            if (n1.Numerator / n1.Denominator < n2.Numerator / n2.Denominator)
                return true;
            return false;
        }
        public static bool operator >(Rational n1, Rational n2)
        {
            if (n1.Numerator / n1.Denominator > n2.Numerator / n2.Denominator)
                return true;
            return false;
        }
        public static bool operator <=(Rational n1, Rational n2)
        {
            if (n1.Numerator / n1.Denominator < n2.Numerator / n2.Denominator || n1.Equals(n2))
                return true;
            return false;
        }
        public static bool operator >=(Rational n1, Rational n2)
        {
            if (n1.Numerator / n1.Denominator > n2.Numerator / n2.Denominator || n1.Equals(n2))
                return true;
            return false;
        }
        public static bool operator ==(Rational n1, Rational n2)
        {
            if (n1 is null || n2 is null)
                return false;
            return n1.Equals(n2);
        }
        public static bool operator !=(Rational n1, Rational n2)
        {
            if (n1 is null || n2 is null)
                return false;
            return !n1.Equals(n2);
        }
    }
}
