namespace Algorithms1
{
    public class PrimeNumber
    {
        public bool IsPrimeNumber(int number)
        {
            // Didn't know how correctly name this vars,
            // so I decided name `incrementer` for `d` and `divider` for `i` 
            
            // first of all we might check `number` param to be positive. If not then throw some exception.
            // Here this wasn't implemented cos in homework task wasn't such requirement
            
            var incrementer = 0;
            var divider = 2;

            while (divider < number)
            {
                if (number % divider == 0)
                {
                    incrementer++;
                }
                
                divider++;
            }

            return incrementer == 0;
        }
    }
}