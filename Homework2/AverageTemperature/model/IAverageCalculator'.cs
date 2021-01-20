namespace AverageTemperature
{
    public interface IAverageCalculator_
    {
        // Currently this method work only with `int`.
        // It can be improved in future using generics
        double CalculatedAverage();
        int CollectionSum();
    }
}