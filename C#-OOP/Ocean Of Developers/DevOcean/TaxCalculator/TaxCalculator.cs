using TaxCalculator.Models;


namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        public readonly Vehicle Vehicle;

        protected TaxCalculator(Vehicle vehicle)
        {
            this.Vehicle = vehicle;
        }

        public abstract int Calculate(int yearOfCalculation);

    }
}