using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGB
{
    public class TestCase
    {
        public int[] input { get; set; }
        public int inputsearch { get; set; }
        public int expected { get; set; }
        public Exception expectedException { get; set; }

        public static void Test(TestCase testCase)
        {
            try
            {
                var actual = Program.BinarySearch(testCase.input, testCase.inputsearch);
                if (actual == testCase.expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception e)
            {
                if (testCase.expectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
    }
}
