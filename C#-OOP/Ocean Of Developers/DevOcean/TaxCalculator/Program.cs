using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TaxCalculator.Factory;
using TaxCalculator.Models;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //if the '_' in the miles and the currency in the document is not just for formatting then we will
                //go thru every element in the string and then select all that are not '_' and try to parse them
                //Example: milesTraveled.Select(x=>x!='_').ToString()

                IBuilder spaceshipBuilder = new SpaceshipBuilder();
                var spaceship =(Spaceship) spaceshipBuilder.Build();
                ITaxCalculator spaceshipTax = new SpaceshipTax(spaceship);


                //really don't like the validation here but for now i don't have any clue where to put it :\
                Console.WriteLine("Year of tax calculation: ");
                if (!int.TryParse(Console.ReadLine(), out var yearOfTaxCalc))
                {
                    throw new ArgumentException("Invalid type!");
                }
                if (yearOfTaxCalc < spaceship.YearOfPurchase)
                {
                    throw new ArgumentException("It can only calculate present taxes :|");
                }

                decimal taxes = spaceshipTax.Calculate(yearOfTaxCalc);

                Console.WriteLine($"You have to pay {taxes:f2} DVS to the Big Sister.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
