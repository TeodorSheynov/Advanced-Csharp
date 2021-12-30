using System;
using NUnit.Framework;
using TaxCalculator.Models;

namespace TaxCalculator.Test
{
    [TestFixture]
    public class Tests
    {
        private ITaxCalculator taxCalculator;
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
            Spaceship cargoShip = new CargoShip(yearOfPurchase, milesTraveled);

            Assert.AreEqual(cargoShip.MilesTraveled,milesTraveled);
            Assert.AreEqual(cargoShip.YearOfPurchase,yearOfPurchase);
            
        }

        [Test]
        public void TestVehicleConstructorWithInvalidYearOfPurchase()
        {
            yearOfPurchase = 7800;
            milesTraveled = 2000;
            Spaceship cargoShip;

            Assert.Throws<ArgumentException>(() => cargoShip = new CargoShip(yearOfPurchase, milesTraveled));
        }
        [Test]
        public void TestVehicleConstructorWithInvalidMiles()
        {
            yearOfPurchase = 2000;
            milesTraveled = -2;
            Spaceship cargoShip;

            Assert.Throws<ArgumentException>(() => cargoShip = new CargoShip(yearOfPurchase, milesTraveled));
        }

        [Test]
        public void TestSpaceshipTaxCalculatorCalculateMethodForFamilyShip()
        {
            Spaceship familyShip = new FamilyShip(yearOfPurchase:2300, milesTraveled:2344);
            taxCalculator = new SpaceshipTax(familyShip);

            Assert.AreEqual(expected: 2715.00, actual:taxCalculator.Calculate(yearOfCalculation:2307));
        }

        [Test]
        public void TestSpaceshipTaxCalculatorCalculateMethodForCargoShip()
        {
            Spaceship cargoShip = new CargoShip(yearOfPurchase: 2332, milesTraveled: 344789);
            taxCalculator = new SpaceshipTax(cargoShip);
            Assert.AreEqual(expected: 326768.00, taxCalculator.Calculate(yearOfCalculation:2369));
        }
    }
}