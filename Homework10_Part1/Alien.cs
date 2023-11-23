using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    abstract class Alien
    {
        private int health; // 0 = dead, 100 = full
        private string name;

        protected Alien(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        public abstract int GetDamage();

      
    }

}
