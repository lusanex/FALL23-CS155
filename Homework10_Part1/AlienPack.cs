﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        public Alien[] GetAliens()
        {
            return aliens;
        }

        public int CalculateDamage()
        {
            int damage = 0;
            foreach (Alien a in aliens)
            {
                if (a != null)
                {
                    damage += a.GetDamage();
                }
            }
            return damage;
        }
    }
}
