namespace TaxCalculator.Models
{
    public class FamilyShip:Vehicle
    {
        private const int INITIAL_TAX_CONST = 5000;
        private const int ADDITIONAL_TAX_CONST = 100;
        private const int TAX_DECLINE_CONST = 355;
        public FamilyShip(int yearOfPurchase, int milesTraveled) 
            : base(yearOfPurchase, milesTraveled)
        {

        }

        public override int InitialTax => INITIAL_TAX_CONST;

        public override int AdditionalTax => ADDITIONAL_TAX_CONST;
        public override int TaxDecline => TAX_DECLINE_CONST;

       
    }
}