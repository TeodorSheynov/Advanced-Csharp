namespace TaxCalculator.Models
{
    public class CargoShip:Spaceship
    {
        private const decimal INITIAL_TAX_CONST =10000m;
        private const decimal ADDITIONAL_TAX_CONST = 1000m;
        private const decimal TAX_DECLINE_CONST = 736m;

        public CargoShip(int yearOfPurchase, int milesTraveled) 
            : base(yearOfPurchase, milesTraveled)
        {

        }

        public override decimal InitialTax => INITIAL_TAX_CONST;
        public override decimal AdditionalTax => ADDITIONAL_TAX_CONST;
        public override decimal TaxDecline => TAX_DECLINE_CONST;

        
    }
}