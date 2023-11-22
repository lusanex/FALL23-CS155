using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Part1
{
    public class DuelSimulation
    {
        Duelist Aaron = new Duelist("Aaron", 1.0 / 3);
        Duelist Bob = new Duelist("Bob", 1.0 / 2);
        Duelist Charlie = new Duelist("Charlie", 0.995);
        int AaronWins = 0;
        int BobWins = 0;
        int CharlieWins = 0;

        public void SimulateDuel(bool aaronMissesFirstShot)
        {
            Aaron.Reset();
            Bob.Reset();
            Charlie.Reset();

            while ((Aaron.IsAlive && Bob.IsAlive) || 
                (Bob.IsAlive && Charlie.IsAlive) || 
                (Charlie.IsAlive && Aaron.IsAlive))

            {
                if (Aaron.IsAlive)
                {
                    if (!aaronMissesFirstShot || Bob.IsAlive || !Charlie.IsAlive)
                    {
                        Aaron.ShootAtTarget(Charlie.IsAlive ? Charlie : Bob);
                    }
                }

                if (Bob.IsAlive)
                {
                    Bob.ShootAtTarget(Charlie.IsAlive ? Charlie : Aaron);
                }

                if (Charlie.IsAlive)
                {
                    Charlie.ShootAtTarget(Aaron.IsAlive ? Aaron : Bob);
                }
            }

            if (Aaron.IsAlive) AaronWins++;
            else if (Bob.IsAlive) BobWins++;
            else if (Charlie.IsAlive) CharlieWins++;
        }

        public void RunSimulation()
        {
            for (int i = 0; i < 10000; i++)
            {
                SimulateDuel(false);
            }

            Console.WriteLine("Without Aaron missing first shot:");
            Console.WriteLine($"Aaron won {AaronWins}/10000 duels or {AaronWins / 100.0}%");
            Console.WriteLine($"Bob won {BobWins}/10000 duels or {BobWins / 100.0}%");
            Console.WriteLine($"Charlie won {CharlieWins}/10000 duels or {CharlieWins / 100.0}%");

            AaronWins = BobWins = CharlieWins = 0;

            for (int i = 0; i < 10000; i++)
            {
                SimulateDuel(true);
            }

            Console.WriteLine("\nWith Aaron missing first shot:");
            Console.WriteLine($"Aaron won {AaronWins}/10000 duels or {AaronWins / 100.0}%");
            Console.WriteLine($"Bob won {BobWins}/10000 duels or {BobWins / 100.0}%");
            Console.WriteLine($"Charlie won {CharlieWins}/10000 duels or {CharlieWins / 100.0}%");
        }
    }
}
