using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Part1
{

    public class Odometer
    {
        private double mileageDriven;
        private double fuelUsed;

        // No-argument constructor
        public Odometer()
        {
            mileageDriven = 0;
            fuelUsed = 0;
        }

        // Constructor with parameters
        public Odometer(double mileage, double fuel)
        {
            mileageDriven = mileage;
            fuelUsed = fuel;
        }

        // Reset method
        public void Reset()
        {
            mileageDriven = 0;
            fuelUsed = 0;
        }

        // Add method
        public void Add(double miles, double fuel)
        {
            mileageDriven += miles;
            fuelUsed += fuel;
        }

        // Calculate miles per gallon
        public double CalculateMilesPerGallon()
        {
            if (fuelUsed == 0) return 0;
            return mileageDriven / fuelUsed;
        }

        // ToString method
        public override string ToString()
        {
            return $"Mileage: {mileageDriven} miles, Fuel used: {fuelUsed} gallons, MPG: {CalculateMilesPerGallon()}";
        }
    }
}
