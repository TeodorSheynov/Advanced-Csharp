using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TaxCalculator.Models;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //if the '_' in the miles and the currency is not just for formatting in the document then we will
                //go thru every el in the string and and select all that are not '_' then try to parse
                //Example: milesTraveled.Select(x=>x!='_').ToString()

                Console.WriteLine("Year of purchase: ");
                if (!int.TryParse(Console.ReadLine(), out int yearOfPurchase))
                {
                    throw new ArgumentException("Invalid type!");
                }

                Console.WriteLine("Miles traveled: ");
                if (!int.TryParse(Console.ReadLine(), out int milesTraveled))
                {
                    throw new ArgumentException("Invalid type!");
                }
                

                Console.WriteLine("Year of tax calculation: ");
                if (!int.TryParse(Console.ReadLine(), out int yearOfTaxCalc))
                {
                    throw new ArgumentException("Invalid type!");
                }

                if (yearOfTaxCalc < yearOfPurchase)
                {
                    throw new ArgumentException("It can only calculate present taxes :|");
                }


                Console.WriteLine("Ship type: ");
                string type = Console.ReadLine();


                Creator vehicleCreator = new ShipCreator();
                Vehicle vehicle = vehicleCreator.ShipFactory(type, yearOfPurchase, milesTraveled);



                TaxCalculator spaceshipTax = new SpaceshipTax(vehicle);
                int taxes = spaceshipTax.Calculate(yearOfTaxCalc);
                Console.WriteLine($"You have to pay {taxes}DVS to the Big Sister.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
