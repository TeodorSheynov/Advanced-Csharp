using TaxCalculator.Models;

namespace TaxCalculator
{
    public class SpaceshipTax:TaxCalculator
    {
        public SpaceshipTax(Vehicle vehicle) 
            : base(vehicle)
        {
        }

        public override int Calculate(int yearOfCalculation)
        {
            var years = yearOfCalculation - Vehicle.YearOfPurchase;
            var miles = Vehicle.MilesTraveled / 1000;
            var initialTax = Vehicle.InitialTax;
            var additionalTax = Vehicle.AdditionalTax;
            var taxDecline = Vehicle.TaxDecline;


            var taxes = initialTax + miles * additionalTax - years * taxDecline;
            return taxes;
        }
    }
}