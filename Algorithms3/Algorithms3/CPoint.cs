using System;

namespace Algorithms3
{
    /// <summary>
    /// Representing Point class
    /// </summary>
    public class CPoint<T>
    { 
        public T X { get; set; } 
        public T Y { get; set; }

        public CPoint(T x, T y)
        { 
            X = x; 
            Y = y; 
        }
    }
}