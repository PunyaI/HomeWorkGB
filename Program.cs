using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;

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

            //Console.WriteLine("Тестирование №1");
            //TestCase.Test(testcase1);
            //Console.WriteLine();
            //Console.WriteLine("Тестирование №2");
            //TestCase.Test(testcase2);
            //Console.WriteLine();
            //Console.WriteLine("Тестирование №3");
            //TestCase.Test(testcase3);
            //Console.WriteLine();





            Console.WriteLine("Замер производительности при малом количестве вычислений (порядка 10)");
            Console.WriteLine();
            MyBenchmark(2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Замер производительности при большом количестве вычислений (порядка 1 000 000 000)");
            Console.WriteLine();
            MyBenchmark(100000000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Замер производительности при огромном количестве вычислений (порядка 10 000 000 000)"); //(порядка 100 000 000 000)
            Console.WriteLine();
            MyBenchmark(1000000000);



            //BenchmarkSwitcher.FromAssembly(typeof(BechmarkClass).Assembly).Run(args);
        }
        static void MyBenchmark(float n)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            PointClass point1F = new PointClass() { X = 54.972313123123F, Y = 6F };
            PointClass point2F = new PointClass() { X = 371.2322323232F, Y = 15.7F };
            PointClass point3F = new PointClass() { X = 54.97F, Y = 16.2F };
            PointClass point4F = new PointClass() { X = 371.232F, Y = 125.7F };
            PointClass point5F = new PointClass() { X = 547.7231312368F, Y = 6F };
            PointClass point6F = new PointClass() { X = 31.222312312F, Y = 15.7F };
            PointClass point7F = new PointClass() { X = 4.7F, Y = 65.4F };
            PointClass point8F = new PointClass() { X = 371.22F, Y = 1.72313125667F };
            PointClass[] classpointsF = new PointClass[13] { point1F, point2F, point3F, point4F, point5F, point6F, point7F, point8F, point1F, point3F, point5F, point7F, point1F };
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    PointDistance.PointDistanceClassFloat(classpointsF[i], classpointsF[i + 1]);
                }
            }
            timer.Stop();
            Console.WriteLine("Класс Point и тип данных Float. Выполнение заняло " + timer.ElapsedMilliseconds + " мс");
            Console.WriteLine("Или " + timer.Elapsed + " нс");
            Console.WriteLine();
            timer.Reset();


            timer.Start();
            PointStruct point1structF = new PointStruct() { X = 54.972313123123F, Y = 6F };
            PointStruct point2structF = new PointStruct() { X = 371.2322323232F, Y = 15.7F };
            PointStruct point3structF = new PointStruct() { X = 54.97F, Y = 16.2F };
            PointStruct point4structF = new PointStruct() { X = 371.232F, Y = 125.7F };
            PointStruct point5structF = new PointStruct() { X = 547.72313123687F, Y = 6F };
            PointStruct point6structF = new PointStruct() { X = 31.222312312F, Y = 15.7F };
            PointStruct point7structF = new PointStruct() { X = 4.7F, Y = 65.4F };
            PointStruct point8structF = new PointStruct() { X = 371.22F, Y = 1.72313125667F };
            PointStruct[] structpointsF = new PointStruct[13] { point1structF, point2structF, point3structF, point4structF, point5structF, point6structF, point7structF, point8structF, point1structF, point3structF, point5structF, point7structF, point1structF };
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    PointDistance.PointDistanceStructFloat(structpointsF[i], structpointsF[i + 1]);
                }
            }

            timer.Stop();
            Console.WriteLine("Структура Point и тип данных Float. Выполнение заняло " + timer.ElapsedMilliseconds + " мс");
            Console.WriteLine("Или " + timer.Elapsed + " нс");
            Console.WriteLine();
            timer.Reset();


            timer.Start();
            PointStructDouble point1structD = new PointStructDouble() { X = 54.972313123123D, Y = 6D };
            PointStructDouble point2structD = new PointStructDouble() { X = 371.2322323232D, Y = 15.7D };
            PointStructDouble point3structD = new PointStructDouble() { X = 54.97D, Y = 16.2D };
            PointStructDouble point4structD = new PointStructDouble() { X = 371.232D, Y = 125.7D };
            PointStructDouble point5structD = new PointStructDouble() { X = 547.77231312368D, Y = 6D };
            PointStructDouble point6structD = new PointStructDouble() { X = 31.222312312D, Y = 15.7D };
            PointStructDouble point7structD = new PointStructDouble() { X = 4.7D, Y = 65.4D };
            PointStructDouble point8structD = new PointStructDouble() { X = 371.22D, Y = 1.72313125667D };
            PointStructDouble[] structpointsD = new PointStructDouble[13] { point1structD, point2structD, point3structD, point4structD, point5structD, point6structD, point7structD, point8structD, point1structD, point3structD, point5structD, point7structD, point1structD };
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    PointDistance.PointDistanceStructDouble(structpointsD[i], structpointsD[i + 1]);
                }
            }

            timer.Stop();
            Console.WriteLine("Структура Point и тип данных Double. Выполнение заняло " + timer.ElapsedMilliseconds + " мс");
            Console.WriteLine("Или " + timer.Elapsed + " нс");
            Console.WriteLine();
            timer.Reset();


            timer.Start();
            PointStruct point1struct = new PointStruct() { X = 54.972313123123F, Y = 6F };
            PointStruct point2struct = new PointStruct() { X = 371.2322323232F, Y = 15.7F };
            PointStruct point3struct = new PointStruct() { X = 54.97F, Y = 16.2F };
            PointStruct point4struct = new PointStruct() { X = 371.232F, Y = 125.7F };
            PointStruct point5struct = new PointStruct() { X = 547.72313123687F, Y = 6F };
            PointStruct point6struct = new PointStruct() { X = 31.222312312F, Y = 15.7F };
            PointStruct point7struct = new PointStruct() { X = 4.7F, Y = 65.4F };
            PointStruct point8struct = new PointStruct() { X = 371.22F, Y = 1.72313125667F };
            PointStruct[] structpoints = new PointStruct[13] { point1struct, point2struct, point3struct, point4struct, point5struct, point6struct, point7struct, point8struct, point1struct, point3struct, point5struct, point7struct, point1struct };
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    PointDistance.PointDistanceStructFloatWithoutSqrt(structpoints[i], structpoints[i + 1]);
                }
            }

            timer.Stop();
            Console.WriteLine("Структура Point и тип данных Float, без Sqrt. Выполнение заняло " + timer.ElapsedMilliseconds + " мс");
            Console.WriteLine("Или " + timer.Elapsed + " нс");
            Console.WriteLine();
            timer.Reset();
        }
    }
    //public class PointGenerator
    //{
        
    //    public static PointClass point1F = new PointClass() { X = 54.972313123123F, Y = 6F };
    //    public static PointClass point2F = new PointClass() { X = 371.2322323232F, Y = 15.7F };
    //    public static PointClass point3F = new PointClass() { X = 54.97F, Y = 16.2F };
    //    public static PointClass point4F = new PointClass() { X = 371.232F, Y = 125.7F };
    //    public static PointClass point5F = new PointClass() { X = 547.7231312368F, Y = 6F };
    //    public static PointClass point6F = new PointClass() { X = 31.222312312F, Y = 15.7F };
    //    public static PointClass point7F = new PointClass() { X = 4.7F, Y = 65.4F };
    //    public static PointClass point8F = new PointClass() { X = 371.22F, Y = 1.72313125667F };
    //    public static PointClass[] classpointsF = new PointClass[13] { point1F, point2F, point3F, point4F, point5F, point6F, point7F, point8F, point1F, point3F, point5F, point7F, point1F };
        
    //    public static PointStruct point1structF = new PointStruct() { X = 54.972313123123F, Y = 6F };
    //    public static PointStruct point2structF = new PointStruct() { X = 371.2322323232F, Y = 15.7F };
    //    public static PointStruct point3structF = new PointStruct() { X = 54.97F, Y = 16.2F };
    //    public static PointStruct point4structF = new PointStruct() { X = 371.232F, Y = 125.7F };
    //    public static PointStruct point5structF = new PointStruct() { X = 547.72313123687F, Y = 6F };
    //    public static PointStruct point6structF = new PointStruct() { X = 31.222312312F, Y = 15.7F };
    //    public static PointStruct point7structF = new PointStruct() { X = 4.7F, Y = 65.4F };
    //    public static PointStruct point8structF = new PointStruct() { X = 371.22F, Y = 1.72313125667F };
    //    public static PointStruct[] structpointsF = new PointStruct[13] { point1structF, point2structF, point3structF, point4structF, point5structF, point6structF, point7structF, point8structF, point1structF, point3structF, point5structF, point7structF, point1structF };
        
    //    public static PointStructDouble point1structD = new PointStructDouble() { X = 54.972313123123D, Y = 6D };
    //    public static PointStructDouble point2structD = new PointStructDouble() { X = 371.2322323232D, Y = 15.7D };
    //    public static PointStructDouble point3structD = new PointStructDouble() { X = 54.97D, Y = 16.2D };
    //    public static PointStructDouble point4structD = new PointStructDouble() { X = 371.232D, Y = 125.7D };
    //    public static PointStructDouble point5structD = new PointStructDouble() { X = 547.77231312368D, Y = 6D };
    //    public static PointStructDouble point6structD = new PointStructDouble() { X = 31.222312312D, Y = 15.7D };
    //    public static PointStructDouble point7structD = new PointStructDouble() { X = 4.7D, Y = 65.4D };
    //    public static PointStructDouble point8structD = new PointStructDouble() { X = 371.22D, Y = 1.72313125667D };
    //    public static PointStructDouble[] structpointsD = new PointStructDouble[13] { point1structD, point2structD, point3structD, point4structD, point5structD, point6structD, point7structD, point8structD, point1structD, point3structD, point5structD, point7structD, point1structD };
    //}
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

        [Benchmark(Description = "Класс Point и тип данных Float")]
        public void TestClassFloat()
        {
        PointClass point1F = new PointClass() { X = 54.972313123123F, Y = 6F };
        PointClass point2F = new PointClass() { X = 371.2322323232F, Y = 15.7F };
        PointClass point3F = new PointClass() { X = 54.97F, Y = 16.2F };
        PointClass point4F = new PointClass() { X = 371.232F, Y = 125.7F };
        PointClass point5F = new PointClass() { X = 547.7231312368F, Y = 6F };
        PointClass point6F = new PointClass() { X = 31.222312312F, Y = 15.7F };
        PointClass point7F = new PointClass() { X = 4.7F, Y = 65.4F };
        PointClass point8F = new PointClass() { X = 371.22F, Y = 1.72313125667F };
        PointClass[] classpointsF = new PointClass[13] { point1F, point2F, point3F, point4F, point5F, point6F, point7F, point8F, point1F, point3F, point5F, point7F, point1F };
            for(int i = 0; i<12;i++)
            {
                //PointDistance.PointDistanceClassFloat(PointGenerator.classpointsF[i], PointGenerator.classpointsF[i + 1]);
                PointDistance.PointDistanceClassFloat(classpointsF[i], classpointsF[i + 1]);
            }
        }

        [Benchmark(Description = "Структура Point и тип данных Float")]
        public void TestStructFloat()
        {
        PointStruct point1structF = new PointStruct() { X = 54.972313123123F, Y = 6F };
        PointStruct point2structF = new PointStruct() { X = 371.2322323232F, Y = 15.7F };
        PointStruct point3structF = new PointStruct() { X = 54.97F, Y = 16.2F };
        PointStruct point4structF = new PointStruct() { X = 371.232F, Y = 125.7F };
        PointStruct point5structF = new PointStruct() { X = 547.72313123687F, Y = 6F };
        PointStruct point6structF = new PointStruct() { X = 31.222312312F, Y = 15.7F };
        PointStruct point7structF = new PointStruct() { X = 4.7F, Y = 65.4F };
        PointStruct point8structF = new PointStruct() { X = 371.22F, Y = 1.72313125667F };
        PointStruct[] structpointsF = new PointStruct[13] { point1structF, point2structF, point3structF, point4structF, point5structF, point6structF, point7structF, point8structF, point1structF, point3structF, point5structF, point7structF, point1structF };
            for (int i = 0; i < 12; i++)
            {
                //PointDistance.PointDistanceStructFloat(PointGenerator.structpointsF[i], PointGenerator.structpointsF[i+1]);
                PointDistance.PointDistanceStructFloat(structpointsF[i], structpointsF[i + 1]);
            }  
        }

        [Benchmark(Description = "Структура Point и тип данных Double")]
        public void TestStructDouble()
        {
        PointStructDouble point1structD = new PointStructDouble() { X = 54.972313123123D, Y = 6D };
        PointStructDouble point2structD = new PointStructDouble() { X = 371.2322323232D, Y = 15.7D };
        PointStructDouble point3structD = new PointStructDouble() { X = 54.97D, Y = 16.2D };
        PointStructDouble point4structD = new PointStructDouble() { X = 371.232D, Y = 125.7D };
        PointStructDouble point5structD = new PointStructDouble() { X = 547.77231312368D, Y = 6D };
        PointStructDouble point6structD = new PointStructDouble() { X = 31.222312312D, Y = 15.7D };
        PointStructDouble point7structD = new PointStructDouble() { X = 4.7D, Y = 65.4D };
        PointStructDouble point8structD = new PointStructDouble() { X = 371.22D, Y = 1.72313125667D };
        PointStructDouble[] structpointsD = new PointStructDouble[13] { point1structD, point2structD, point3structD, point4structD, point5structD, point6structD, point7structD, point8structD, point1structD, point3structD, point5structD, point7structD, point1structD };
            for (int i = 0; i < 12; i++)
            {
                //PointDistance.PointDistanceStructDouble(PointGenerator.structpointsD[i], PointGenerator.structpointsD[i + 1]);
                PointDistance.PointDistanceStructDouble(structpointsD[i], structpointsD[i + 1]);
            }  
        }

        [Benchmark(Description = "Структура Point тип данных Float без Sqrt")]
        public void TestStructFloatNoRoot()
        {
            PointStruct point1structF = new PointStruct() { X = 54.972313123123F, Y = 6F };
            PointStruct point2structF = new PointStruct() { X = 371.2322323232F, Y = 15.7F };
            PointStruct point3structF = new PointStruct() { X = 54.97F, Y = 16.2F };
            PointStruct point4structF = new PointStruct() { X = 371.232F, Y = 125.7F };
            PointStruct point5structF = new PointStruct() { X = 547.72313123687F, Y = 6F };
            PointStruct point6structF = new PointStruct() { X = 31.222312312F, Y = 15.7F };
            PointStruct point7structF = new PointStruct() { X = 4.7F, Y = 65.4F };
            PointStruct point8structF = new PointStruct() { X = 371.22F, Y = 1.72313125667F };
            PointStruct[] structpointsF = new PointStruct[13] { point1structF, point2structF, point3structF, point4structF, point5structF, point6structF, point7structF, point8structF, point1structF, point3structF, point5structF, point7structF, point1structF };
            for (int i = 0; i < 12; i++)
            {
                //PointDistance.PointDistanceStructFloatWithoutSqrt(PointGenerator.structpointsF[i], PointGenerator.structpointsF[i + 1]);
                PointDistance.PointDistanceStructFloatWithoutSqrt(structpointsF[i], structpointsF[i + 1]);
            }   
        }
    }
    public class PointClass
    {
        public float X;
        public float Y;
    }
    public struct PointStruct
    {
        public float X;
        public float Y;
    }

    public struct PointStructDouble
    {
        public double X;
        public double Y;
    }


    public class PointDistance
    {
        public static float PointDistanceClassFloat(PointClass pointone, PointClass pointtwo)
        {
            float x = pointone.X - pointtwo.X;
            float y = pointone.Y - pointtwo.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceStructFloat(PointStruct pointone, PointStruct pointtwo)
        {
            float x = pointone.X - pointtwo.X;
            float y = pointone.Y - pointtwo.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }
        public static double PointDistanceStructDouble(PointStructDouble pointone, PointStructDouble pointtwo)
        {
            double x = pointone.X - pointtwo.X;
            double y = pointone.Y - pointtwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceStructFloatWithoutSqrt(PointStruct pointone, PointStruct pointtwo)
        {
            float x = pointone.X - pointtwo.X;
            float y = pointone.Y - pointtwo.Y;
            return (x * x) + (y * y);
        }

    }
}

