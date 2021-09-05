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
        PointStruct point1structF = new PointStruct() { X = 5.32F, Y = 6.232F };
        PointStruct point2structF = new PointStruct() { X = 323.232F, Y = 153.232F };
        PointStructDouble point1structD = new PointStructDouble() { X = 5.32D, Y = 6.232D };
        PointStructDouble point2structD = new PointStructDouble() { X = 323.232D, Y = 153.232D };

        [Benchmark(Description = "Класс Point и тип данных Float")]
        public void TestClassFloat()
        {
            PointDistance.PointDistanceClassFloat(point1F, point2F);
        }

        [Benchmark(Description = "Структура Point и тип данных Float")]
        public void TestStructFloat()
        {
            PointDistance.PointDistanceStructFloat(point1structF, point2structF);
        }

        [Benchmark(Description = "Структура Point и тип данных Double")]
        public void TestStructDouble()
        {
            PointDistance.PointDistanceStructDouble(point1structD, point2structD);
        }

        [Benchmark(Description = "Структура Point тип данных Float без Sqrt")]
        public void TestStructFloatNoRoot()
        {
            PointDistance.PointDistanceStructFloatWithoutSqrt(point1structF, point2structF);
        }

    }
}

