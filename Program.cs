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
        [Benchmark]
        public void TestClassFloat()
        {
            var point1 = new PointClass() { X = 5.32F, Y = 6.232F };
            var point2 = new PointClass() { X = 323.232F, Y = 153.232F };
            PointDistance.PointDistanceClassFloat(point1, point2);

        }
        [Benchmark]
        public void TestStructFloat()
        {
            var point1 = new PointStruct() { X = 5.32F, Y = 6.232F };
            var point2 = new PointStruct() { X = 323.232F, Y = 153.232F };
            PointDistance.PointDistanceStructFloat(point1, point2);
        }
        [Benchmark]
        public void TestStructDouble()
        {
            var point1 = new PointStructDouble() { X = 5.32D, Y = 6.232D };
            var point2 = new PointStructDouble() { X = 323.232D, Y = 153.232D };
            PointDistance.PointDistanceStructDouble(point1, point2);
        }
        [Benchmark]
        public void TestStructFloatNoRoot()
        {
            var point1 = new PointStruct() { X = 5.32F, Y = 6.232F };
            var point2 = new PointStruct() { X = 323.232F, Y = 153.232F };
            PointDistance.PointDistanceStructFloatWithoutRoot(point1, point2);
        }

    }
}

