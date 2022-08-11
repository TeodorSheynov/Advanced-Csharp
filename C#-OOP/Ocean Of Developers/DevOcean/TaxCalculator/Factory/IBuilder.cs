using TaxCalculator.Models;

namespace TaxCalculator.Factory
{
    public interface IBuilder
    {
        Spaceship Build();
    }
}