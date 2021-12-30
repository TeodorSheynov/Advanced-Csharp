using TaxCalculator.Models;

namespace TaxCalculator
{
    public class SpaceshipTax:ITaxCalculator
    {
        private readonly Spaceship _spaceship;
        public SpaceshipTax(Spaceship spaceship)
        {
            this._spaceship = spaceship;
        }

        public  decimal Calculate(int yearOfCalculation)
        {
            var years = yearOfCalculation - _spaceship.YearOfPurchase;
            var miles = _spaceship.MilesTraveled / 1000;
            var initialTax = _spaceship.InitialTax;
            var additionalTax = _spaceship.AdditionalTax;
            var taxDecline = _spaceship.TaxDecline;


            var taxes = initialTax + miles * additionalTax - years * taxDecline;
            return taxes;
        }
    }
}