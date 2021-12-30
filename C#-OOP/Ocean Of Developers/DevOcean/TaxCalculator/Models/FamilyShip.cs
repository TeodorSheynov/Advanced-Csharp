namespace TaxCalculator.Models
{
    public class FamilyShip:Spaceship
    {
        private const decimal INITIAL_TAX_CONST = 5000m;
        private const decimal ADDITIONAL_TAX_CONST = 100m;
        private const decimal TAX_DECLINE_CONST = 355m;
        public FamilyShip(int yearOfPurchase, int milesTraveled) 
            : base(yearOfPurchase, milesTraveled)
        {

        }

        public override decimal InitialTax => INITIAL_TAX_CONST;

        public override decimal AdditionalTax => ADDITIONAL_TAX_CONST;
        public override decimal TaxDecline => TAX_DECLINE_CONST;

       
    }
}