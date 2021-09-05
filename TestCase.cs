using System;

namespace HomeWorkGB
{
    public class TestCase
    {
        public PointClass inputPointClass1 { get; set; }
        public PointClass inputPointClass2 { get; set; }
        public PointStruct inputPointSF1 { get; set; }
        public PointStruct inputPointSF2 { get; set; }
        public PointStructDouble inputPointSD1 { get; set; }
        public PointStructDouble inputPointSD2 { get; set; }
        public double expectedF { get; set; }
        public double expectedD { get; set; }
        public Exception expectedException { get; set; }

        public static void Test(TestCase testCase)
        {
            try
            {
                var actual1 = PointDistance.PointDistanceClassFloat (testCase.inputPointClass1, testCase.inputPointClass2);
                if (actual1 == testCase.expectedF)
                {
                    Console.WriteLine("VALID TEST1");
                }
                else
                {
                    Console.WriteLine("INVALID TEST1");
                }
            }
            catch (Exception e)
            {
                if (testCase.expectedException != null)
                {
                    Console.WriteLine("VALID TEST1");
                }
                else
                {
                    Console.WriteLine("INVALID TEST1");
                }
            }
            try
            {
                var actual2 = PointDistance.PointDistanceStructFloat(testCase.inputPointSF1, testCase.inputPointSF2);
                if (actual2 == testCase.expectedF)
                {
                    Console.WriteLine("VALID TEST2");
                }
                else
                {
                    Console.WriteLine("INVALID TEST2");
                }
            }
            catch (Exception e)
            {
                if (testCase.expectedException != null)
                {
                    Console.WriteLine("VALID TEST2");
                }
                else
                {
                    Console.WriteLine("INVALID TEST2");
                }
            }
            try
            {
                var actual3 = PointDistance.PointDistanceStructDouble(testCase.inputPointSD1, testCase.inputPointSD2);
                if (actual3 == testCase.expectedD)
                {
                    Console.WriteLine("VALID TEST3");
                }
                else
                {
                    Console.WriteLine("INVALID TEST3");
                }
            }
            catch (Exception e)
            {
                if (testCase.expectedException != null)
                {
                    Console.WriteLine("VALID TEST3");
                }
                else
                {
                    Console.WriteLine("INVALID TEST3");
                }
            }
            try
            {
                var actual4 = PointDistance.PointDistanceStructFloatWithoutSqrt(testCase.inputPointSF1, testCase.inputPointSF2);
                if ((float)Math.Sqrt(actual4) == testCase.expectedF)
                {
                    Console.WriteLine("VALID TEST4");
                }
                else
                {
                    Console.WriteLine("INVALID TEST4");
                }
            }
            catch (Exception e)
            {
                if (testCase.expectedException != null)
                {
                    Console.WriteLine("VALID TEST4");
                }
                else
                {
                    Console.WriteLine("INVALID TEST4");
                }
            }
        }
    }
}
