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
               
                IBuilder spaceshipBuilder = new SpaceshipBuilder();
                var spaceship =spaceshipBuilder.Build();
                TaxCalculator taxCalculator = new SpaceShipTaxCalculator(spaceship);
                decimal taxes = taxCalculator.Calculate();
                Console.WriteLine($"You have to pay {taxes:f2} DVS to the Big Sister.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
