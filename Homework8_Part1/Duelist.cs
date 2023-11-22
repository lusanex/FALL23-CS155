using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Part1
{
    public class Duelist
    {
        public string Name { get; private set; }
        public double Accuracy { get; private set; }
        public bool IsAlive { get; private set; }

        public Duelist(string name, double accuracy)
        {
            Name = name;
            Accuracy = accuracy;
            IsAlive = true;
        }

        public void ShootAtTarget(Duelist target)
        {
            if (new Random().NextDouble() < Accuracy)
            {
                target.IsAlive = false;
            }
        }

        public void Reset()
        {
            IsAlive = true;
        }
    }
}
