
namespace Algorithms1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        // Asymptotic complexity for this method if O(n^3), cos here we have 3 nested loops with same array lenght.
        // This means that time complexity of this method is cubic.
        // Example: if `input array` have 8 elements, then there will be approx 512 iterations 
        public static int StrangeSum(int[] inputArray) 
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) 
            {
                for (int j = 0; j < inputArray.Length; j++) 
                {
                    for (int k = 0; k < inputArray.Length; k++) 
                    {
                        int y = 0;
                        if (j != 0) 
                        {
                            y = k / j; 
                        }
                        sum += inputArray[i] + i + k + j + y; 
                    }
                } 
            }
            return sum; 
        }
    }
}