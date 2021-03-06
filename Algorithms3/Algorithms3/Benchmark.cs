using System;
using BenchmarkDotNet.Attributes;

namespace Algorithms3
{
    public class Benchmark
    {
        private float CPointSum(CPoint pointOne, CPoint pointTwo)
        {
            var xValue = pointOne.X - pointTwo.X;
            var yValue = pointOne.Y - pointTwo.Y;

            return MathF.Sqrt((xValue * xValue) + (yValue * yValue));
        }

        private float SPointSum(SPoint pointOne, SPoint pointTwo)
        {
            var xValue = pointOne.X - pointTwo.X;
            var yValue = pointOne.Y - pointTwo.Y;

            return MathF.Sqrt((xValue * xValue) + (yValue * yValue));
        }
        
        [Benchmark]
        public void TestClassPoint()
        {
            var pointOne = new CPoint(43, 74);
            var pointTwo = new CPoint(12, 7);

            CPointSum(pointOne, pointTwo);
        }
    }
}