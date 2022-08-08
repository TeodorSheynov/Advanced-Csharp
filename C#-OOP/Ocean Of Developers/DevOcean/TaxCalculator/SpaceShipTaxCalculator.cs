using System;
using TaxCalculator.Models;

namespace TaxCalculator
{
    public class SpaceShipTaxCalculator:TaxCalculator
    {
        private readonly Spaceship _spaceship;
        public SpaceShipTaxCalculator(Spaceship spaceship)
        {
            this._spaceship = spaceship;
        }

        protected override int TakeYearOfCalculation()
        {
            Console.WriteLine("Year of tax calculation: ");
            var inputYear = Console.ReadLine();
            if (!int.TryParse(inputYear, out var yearOfTaxCalculation))
            {
                throw new ArgumentException("Invalid type!");
            }
            if (yearOfTaxCalculation < _spaceship.YearOfPurchase)
            {
                throw new ArgumentException("It can calculate only taxes since the purchase of the vehicle :|");
            }
            return yearOfTaxCalculation;
        }

        public override decimal Calculate()
        {
            var yearOfCalculation = TakeYearOfCalculation();
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