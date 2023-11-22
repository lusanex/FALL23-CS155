using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Manufacturer
{
    Toyota, Ford, Honda, Chevrolet 
}
namespace Homework9_Part1
{
    public class Vehicle
    {
        public Manufacturer ManufacturerName { get; set; }
        public int NumberOfCylinders { get; set; }
        public Person Owner { get; set; }

        public Vehicle(Manufacturer manufacturer, int cylinders, Person owner)
        {
            ManufacturerName = manufacturer;
            NumberOfCylinders = cylinders;
            Owner = owner;
        }

        public override string ToString()
        {
            return $"Vehicle: {ManufacturerName}, Cylinders: {NumberOfCylinders}, Owner: {Owner}";
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Vehicle))
                return false;
            Vehicle other = (Vehicle)obj;
            return ManufacturerName == other.ManufacturerName &&
                   NumberOfCylinders == other.NumberOfCylinders &&
                   Owner.Equals(other.Owner);
        }
    }
}
