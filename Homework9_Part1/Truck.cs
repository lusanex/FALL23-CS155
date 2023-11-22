using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1
{
    public class Truck : Vehicle
    {
        public double LoadCapacityTons { get; set; }
        public int TowingCapacityPounds { get; set; }

        public Truck(Manufacturer manufacturer, int cylinders, Person owner, double loadCapacity, int towingCapacity)
            : base(manufacturer, cylinders, owner)
        {
            LoadCapacityTons = loadCapacity;
            TowingCapacityPounds = towingCapacity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Load Capacity: {LoadCapacityTons} tons, Towing Capacity: {TowingCapacityPounds} pounds";
        }

        public override bool Equals(Object obj)
        {
            if (!base.Equals(obj) || !(obj is Truck))
                return false;
            Truck other = (Truck)obj;
            return LoadCapacityTons == other.LoadCapacityTons &&
                   TowingCapacityPounds == other.TowingCapacityPounds;
        }
    }

}
