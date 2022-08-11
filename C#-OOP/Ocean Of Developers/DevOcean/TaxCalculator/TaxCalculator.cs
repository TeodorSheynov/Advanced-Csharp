using System;

namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        protected abstract int TakeYearOfCalculation();

        public abstract decimal Calculate();
    }
}