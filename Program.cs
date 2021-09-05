using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace HomeWorkGB
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

