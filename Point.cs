﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGB
{
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
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceStructFloat(PointStruct pointone, PointStruct pointtwo)
        {
            float x = pointone.X - pointtwo.X;
            float y = pointone.Y - pointtwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static double PointDistanceStructDouble(PointStructDouble pointone, PointStructDouble pointtwo)
        {
            double x = pointone.X - pointtwo.X;
            double y = pointone.Y - pointtwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceStructFloatWithoutRoot(PointStruct pointone, PointStruct pointtwo)
        {
            float x = pointone.X - pointtwo.X;
            float y = pointone.Y - pointtwo.Y;
            float res = x * x + y * y;
            return res;
        }

    }
        
        
}
