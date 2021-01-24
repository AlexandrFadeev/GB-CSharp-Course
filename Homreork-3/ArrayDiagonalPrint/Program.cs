using System;

namespace ArrayDiagonalPrint
{
    
    class Program
    {
        private const string Spaces = "  ";
        private const int MatrixSize = 10;
        
        static void Main(string[] args)
        {
            var matrix = new int[MatrixSize, MatrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 1;
                    }
                    
                    Console.Write($"{matrix[i, j]}{Spaces}");
                }
                Console.WriteLine();
            }
        }
    }
}