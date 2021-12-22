using TaxCalculator.Models;

namespace TaxCalculator
{
    public abstract class Creator
    {
        public abstract Vehicle ShipFactory(string type,int yearOfPurchase,int milesTraveled);
    }
}