using System;
using System.Linq;

namespace AverageTemperature.model
{
    public class AverageCalculator : IAverageCalculator_
    {
        // Initializers
        public AverageCalculator(int[] collection)
        {
            Collection = collection;
        }
        
        // Private propertis
        public int[] Collection { get; set; }

        // Interface implementation
        public double CalculatedAverage()
        {
            double sum = CollectionSum();
            double collecitonLenght = Collection.Length;

            return sum / collecitonLenght;
        }

        public int CollectionSum()
        {
            if (Collection.Length == 0)
            {
                throw new ArgumentException("collection must not be empty");
            }
            
            return Collection.Aggregate((first, second) => first + second);
        }
    }
}
