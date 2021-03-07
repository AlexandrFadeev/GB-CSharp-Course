using System;
using BenchmarkDotNet.Attributes;

namespace Algorithms3
{
    public class Benchmark
    {
        public float CPointFloatSum(CPoint<float> pointOne, CPoint<float> pointTwo)
        {
            var xValue = pointTwo.X - pointOne.X;
            var yValue = pointTwo.Y - pointOne.Y;

            return MathF.Sqrt((xValue * xValue) + (yValue * yValue));
        }

        public double CPointDoubleSum(CPoint<double> pointOne, CPoint<double> pointTwo)
        {
            var xValue = pointTwo.X - pointOne.X;
            var yValue = pointTwo.Y - pointOne.Y;

            return Math.Sqrt((xValue * xValue) + (yValue * yValue));
        }

        public float SPointFloatSum(SPoint<float> pointOne, SPoint<float> pointTwo)
        {
            var xValue = pointTwo.X - pointOne.X;
            var yValue = pointTwo.Y - pointOne.Y;
            
            return MathF.Sqrt((xValue * xValue) + (yValue * yValue));
        }

        public double SpointDoubleSum(SPoint<double> pointOne, SPoint<double> pointTwo)
        {
            var xValue = pointTwo.X - pointOne.X;
            var yValue = pointTwo.Y - pointOne.Y;

            return Math.Sqrt((xValue * xValue) + (yValue * yValue));
        }

        [Benchmark]
        public void TestClassFloatPoint()
        {
            var pointOne = new CPoint<float>(43, 74);
            var pointTwo = new CPoint<float>(12, 7);

            CPointFloatSum(pointOne, pointTwo);
        }
        
        [Benchmark]
        public void TestClassDoublePoint()
        {
            var pointOne = new CPoint<double>(43, 74);
            var pointTwo = new CPoint<double>(12, 7);

            CPointDoubleSum(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestStructFloatPoint()
        {
            var pointOne = new SPoint<float>(43, 74);
            var pointTwo = new SPoint<float>(12, 7);

            SPointFloatSum(pointOne, pointTwo);
        }
        
        [Benchmark]
        public void TestStructDoublePoint()
        {
            var pointOne = new SPoint<double>(43, 74);
            var pointTwo = new SPoint<double>(12, 7);

            SpointDoubleSum(pointOne, pointTwo);
        }
    }
}