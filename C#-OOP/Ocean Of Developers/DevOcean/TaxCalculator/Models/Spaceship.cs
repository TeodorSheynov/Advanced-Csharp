using System;
using TaxCalculator.Models.Contracts;
using TaxCalculator.Models.Messages;

namespace TaxCalculator.Models
{
    public abstract class Spaceship:IVehicle,ITaxable
    {
       
        private int _miles;
        private int _year;

        protected Spaceship(int yearOfPurchase,int milesTraveled)
        {
            this.YearOfPurchase = yearOfPurchase;
            this.MilesTraveled = milesTraveled;
        }

        public abstract decimal InitialTax { get; }
        public abstract decimal AdditionalTax { get;}
        public abstract decimal TaxDecline { get; }


        public int MilesTraveled
        {
            get => _miles;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ShipExceptions.InvalidMiles);
                }
                _miles = value;
            }
        }

        public int YearOfPurchase
        {
            get => _year;
            private set
            {
                if (value > 2345)
                {
                    throw new ArgumentException(ShipExceptions.InvalidYear);
                }

                _year = value;
            }

        }
    }
}