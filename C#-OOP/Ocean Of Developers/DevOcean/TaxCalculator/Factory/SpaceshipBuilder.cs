using System;
using TaxCalculator.Models;

namespace TaxCalculator.Factory
{
    public class SpaceshipBuilder:IBuilder
    {
        public object Build()
        {
            Console.WriteLine("Year of purchase: ");
            if (!int.TryParse(Console.ReadLine(), out var yearOfPurchase))
            {
                throw new ArgumentException("Invalid type!");
            }

            Console.WriteLine("Miles traveled: ");
            if (!int.TryParse(Console.ReadLine(), out var milesTraveled))
            {
                throw new ArgumentException("Invalid type!");
            }

            Console.WriteLine("Ship type: ");
            
            var type = Console.ReadLine();
            if (string.IsNullOrEmpty(type))
            {
                throw new ArgumentNullException();
            }

            return type.ToLower() switch
            {
                "family" => new FamilyShip(yearOfPurchase, milesTraveled),
                "cargo" => new CargoShip(yearOfPurchase, milesTraveled),
                _ => throw new ArgumentException("Not existing type")
            };
        }


    }
}