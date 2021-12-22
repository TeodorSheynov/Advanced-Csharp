using System;
using System.Threading.Channels;
using TaxCalculator.Models;

namespace TaxCalculator
{
    public class ShipCreator:Creator
    {
        public override Vehicle ShipFactory(string type,int yearOfPurchase,int milesTraveled)
        {
            return type.ToLower() switch
            {
                "family" => new FamilyShip(yearOfPurchase, milesTraveled),
                "cargo" => new CargoShip(yearOfPurchase, milesTraveled),
                _ => throw new ArgumentException("Not existing type")
            };
        }


    }
}