using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HomeWorkGeekBrains
{
    [Serializable]
    public class MyArraySizeException:Exception
    {
       public MyArraySizeException(string message):base(message)
        {
        }
    }
    public class MyArrayDataException : Exception
    {
        public int x { get; }
        public int y { get; }

        public MyArrayDataException(string message, int x, int y):base(message)
        {
            this.x = x;
            this.y = y;
        }

    }
}
