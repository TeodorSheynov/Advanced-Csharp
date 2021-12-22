using System;
using NUnit.Framework;
using TaxCalculator.Models;

namespace TaxCalculator.Test
{
    [TestFixture]
    public class Tests
    {
        private TaxCalculator taxCalculator;
        private int yearOfPurchase;
        private int milesTraveled;

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestVehicleConstructorWIthCorrectInput()
        {
            yearOfPurchase = 2022;
            milesTraveled = 2000;
            Vehicle cargoShip = new CargoShip(yearOfPurchase, milesTraveled);

            Assert.AreEqual(cargoShip.MilesTraveled,milesTraveled);
            Assert.AreEqual(cargoShip.YearOfPurchase,yearOfPurchase);
            
        }

        [Test]
        public void TestVehicleConstructorWithInvalidYearOfPurchase()
        {
            yearOfPurchase = 7800;
            milesTraveled = 2000;
            Vehicle cargoShip;

            Assert.Throws<ArgumentException>(() => cargoShip = new CargoShip(yearOfPurchase, milesTraveled));
        }
        [Test]
        public void TestVehicleConstructorWithInvalidMiles()
        {
            yearOfPurchase = 2000;
            milesTraveled = -2;
            Vehicle cargoShip;

            Assert.Throws<ArgumentException>(() => cargoShip = new CargoShip(yearOfPurchase, milesTraveled));
        }

        [Test]
        public void TestSpaceshipTaxCalculatorCalculateMethodForFamilyShip()
        {
            Vehicle familyShip = new FamilyShip(yearOfPurchase:2300, milesTraveled:2344);
            taxCalculator = new SpaceshipTax(familyShip);

            Assert.AreEqual(expected: 2715, actual:taxCalculator.Calculate(yearOfCalculation:2307));
        }

        [Test]
        public void TestSpaceshipTaxCalculatorCalculateMethodForCargoShip()
        {
            Vehicle cargoShip = new CargoShip(yearOfPurchase: 2332, milesTraveled: 344789);
            taxCalculator = new SpaceshipTax(cargoShip);
            Assert.AreEqual(expected: 326768, taxCalculator.Calculate(yearOfCalculation:2369));
        }
    }
}