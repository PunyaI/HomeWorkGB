using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;
using System;


namespace HomeWorkGB
{
    class Program
    {
        static void Main(string[] args)
        {

            var testcase1 = new TestCase()
            {
                inputPointClass1 = new PointClass() { X = 0, Y = 4},
                inputPointClass2 = new PointClass() { X = 0, Y = 0},
                inputPointSF1 = new PointStruct() { X = 0, Y = 4 },
                inputPointSF2 = new PointStruct() { X = 0, Y = 0 },
                inputPointSD1 = new PointStructDouble() { X = 0, Y = 4 },
                inputPointSD2 = new PointStructDouble() { X = 0, Y = 0 },
                expectedF = 4F,
                expectedD = 4D,
                expectedException = null
            };
            var testcase2 = new TestCase()
            {
                inputPointClass1 = new PointClass() { X = 2.1F, Y = 3.2F },
                inputPointClass2 = new PointClass() { X = 4.55F, Y = 8.85F },
                inputPointSF1 = new PointStruct() { X = 2.1F, Y = 3.2F },
                inputPointSF2 = new PointStruct() { X = 4.55F, Y = 8.85F },
                inputPointSD1 = new PointStructDouble() { X = 2.1D, Y = 3.2D },
                inputPointSD2 = new PointStructDouble() { X = 4.55D, Y = 8.85D },
                expectedF = 6.158328F,
                expectedD = 6.1583276950808639D,
                expectedException = null
            };
            var testcase3 = new TestCase()
            {
                inputPointClass1 = new PointClass() { X = 55.98F, Y = 9 },
                inputPointClass2 = new PointClass() { X = 313.2F, Y = 323.21F },
                inputPointSF1 = new PointStruct() { X = 55.98F, Y = 9 },
                inputPointSF2 = new PointStruct() { X = 313.2F, Y = 323.21F },
                inputPointSD1 = new PointStructDouble() { X = 55.98D, Y = 9 },
                inputPointSD2 = new PointStructDouble() { X = 313.2D, Y = 323.21D },
                expectedF = 406.066562F,
                expectedD = 406.06656166200139D,
                expectedException = null
            };

            Console.WriteLine("Тестирование №1");
            TestCase.Test(testcase1);
            Console.WriteLine();
            Console.WriteLine("Тестирование №2");
            TestCase.Test(testcase2);
            Console.WriteLine();
            Console.WriteLine("Тестирование №3");
            TestCase.Test(testcase3);
            Console.WriteLine();

            BenchmarkSwitcher.FromAssembly(typeof(BechmarkClass).Assembly).Run(args);
        }
    }
    internal class Config : ManualConfig
    {
        [Obsolete]
        public Config()
        {
            Add(StatisticColumn.Max);
            Add(StatisticColumn.Min);
            Add(CsvMeasurementsExporter.Default);
            Add(RPlotExporter.Default);
        }
    }
    [Config(typeof(Config))]
    public class BechmarkClass
    {
        PointClass point1F = new PointClass() { X = 5.32F, Y = 6.232F };
        PointClass point2F = new PointClass() { X = 323.232F, Y = 153.232F };
        PointClass point3F = new PointClass() { X = 52.32F, Y = 63.232F };
        PointClass point4F = new PointClass() { X = 3234.23232F, Y = 1534.23232F };
        PointClass point5F = new PointClass() { X = 4, Y = 10 };
        PointClass point6F = new PointClass() { X = 15, Y = 2 };
        PointStruct point1structF = new PointStruct() { X = 5.32F, Y = 6.232F };
        PointStruct point2structF = new PointStruct() { X = 323.232F, Y = 153.232F };
        PointStruct point3structF = new PointStruct() { X = 52.32F, Y = 63.232F };
        PointStruct point4structF = new PointStruct() { X = 3234.23232F, Y = 1534.23232F };
        PointStruct point5structF = new PointStruct() { X = 4, Y = 10 };
        PointStruct point6structF = new PointStruct() { X = 15, Y = 2 };
        PointStructDouble point1structD = new PointStructDouble() { X = 5.32D, Y = 6.232D };
        PointStructDouble point2structD = new PointStructDouble() { X = 323.232D, Y = 153.232D };
        PointStructDouble point3structD = new PointStructDouble() { X = 52.32D, Y = 63.232D };
        PointStructDouble point4structD = new PointStructDouble() { X = 3234.23232D, Y = 1534.23232D };
        PointStructDouble point5structD = new PointStructDouble() { X = 4, Y = 10 };
        PointStructDouble point6structD = new PointStructDouble() { X = 15, Y = 2 };

        [Benchmark(Description = "Класс Point и тип данных Float")]
        public void TestClassFloat()
        {
            PointDistance.PointDistanceClassFloat(point1F, point2F);
            PointDistance.PointDistanceClassFloat(point2F, point3F);
            PointDistance.PointDistanceClassFloat(point3F, point4F);
            PointDistance.PointDistanceClassFloat(point4F, point5F);
            PointDistance.PointDistanceClassFloat(point5F, point6F);
            PointDistance.PointDistanceClassFloat(point6F, point1F);
        }

        [Benchmark(Description = "Структура Point и тип данных Float")]
        public void TestStructFloat()
        {
            PointDistance.PointDistanceStructFloat(point1structF, point2structF);
            PointDistance.PointDistanceStructFloat(point2structF, point3structF);
            PointDistance.PointDistanceStructFloat(point3structF, point4structF);
            PointDistance.PointDistanceStructFloat(point4structF, point5structF);
            PointDistance.PointDistanceStructFloat(point5structF, point6structF);
            PointDistance.PointDistanceStructFloat(point6structF, point1structF);
        }

        [Benchmark(Description = "Структура Point и тип данных Double")]
        public void TestStructDouble()
        {
            PointDistance.PointDistanceStructDouble(point1structD, point2structD);
            PointDistance.PointDistanceStructDouble(point2structD, point3structD);
            PointDistance.PointDistanceStructDouble(point3structD, point4structD);
            PointDistance.PointDistanceStructDouble(point4structD, point5structD);
            PointDistance.PointDistanceStructDouble(point5structD, point6structD);
            PointDistance.PointDistanceStructDouble(point6structD, point1structD);
        }

        [Benchmark(Description = "Структура Point тип данных Float без Sqrt")]
        public void TestStructFloatNoRoot()
        {
            PointDistance.PointDistanceStructFloatWithoutSqrt(point1structF, point2structF);
            PointDistance.PointDistanceStructFloatWithoutSqrt(point2structF, point3structF);
            PointDistance.PointDistanceStructFloatWithoutSqrt(point3structF, point4structF);
            PointDistance.PointDistanceStructFloatWithoutSqrt(point4structF, point5structF);
            PointDistance.PointDistanceStructFloatWithoutSqrt(point5structF, point6structF);
            PointDistance.PointDistanceStructFloatWithoutSqrt(point6structF, point1structF);
        }

    }
}

