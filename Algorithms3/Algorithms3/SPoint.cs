namespace Algorithms3
{
    /// <summary>
    /// Representing Point structure
    /// </summary>
    public struct SPoint<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public SPoint(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}