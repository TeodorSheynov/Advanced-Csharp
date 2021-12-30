using TaxCalculator.Models;


namespace TaxCalculator
{
    public interface ITaxCalculator
    {
        
        decimal Calculate(int yearOfCalculation);

    }
}