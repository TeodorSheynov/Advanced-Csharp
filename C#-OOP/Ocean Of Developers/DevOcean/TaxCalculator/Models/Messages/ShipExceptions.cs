namespace TaxCalculator.Models.Messages
{
    public class ShipExceptions
    {
        public const string InvalidMiles = "Traveled miles can't be a negative number!";
        public const string InvalidYear = "Year of purchase can't be greater than the current!";
    }
}