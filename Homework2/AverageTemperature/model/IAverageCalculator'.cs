namespace AverageTemperature.model
{
    public interface IAverageCalculator
    {
        double CalculatedAverage();
        
        // Currently this method work only with `int` type
        // It can be improved in future using generics
        int CollectionSum();
    }
}