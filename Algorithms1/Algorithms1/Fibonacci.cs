namespace Algorithms1
{
    public class Fibonacci
    {
        // Not the very good solution, with recursive function. We could optimize it by implementing memoization
        // but for this task it's good enough... 
        public long RecursiveFibonacci(int number)
        {
            return number < 2 ? number : RecursiveFibonacci(number - 1) + RecursiveFibonacci(number - 2);
        }

        public long FibonacciLoop(int number)
        {
            var firstOperand = 0;
            var secondOperand = 1;

            for (int i = 0; i < number; i++)
            {
                var tempOperand = firstOperand;
                firstOperand = secondOperand;
                secondOperand = tempOperand + secondOperand;
            }

            return firstOperand;
        }
    }
}