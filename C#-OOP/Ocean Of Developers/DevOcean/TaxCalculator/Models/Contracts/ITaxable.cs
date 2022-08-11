namespace TaxCalculator.Models.Contracts
{
    public interface ITaxable
    {
        decimal InitialTax { get; }
        decimal AdditionalTax { get; }
        decimal TaxDecline { get; }
    }
}