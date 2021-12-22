namespace TaxCalculator.Models
{
    public class CargoShip:Vehicle
    {
        private const int INITIAL_TAX_CONST=10000;
        private const int ADDITIONAL_TAX_CONST = 1000;
        private const int TAX_DECLINE_CONST = 736;

        public CargoShip(int yearOfPurchase, int milesTraveled) 
            : base(yearOfPurchase, milesTraveled)
        {

        }

        public override int InitialTax => INITIAL_TAX_CONST;
        public override int AdditionalTax => ADDITIONAL_TAX_CONST;
        public override int TaxDecline => TAX_DECLINE_CONST;

        
    }
}