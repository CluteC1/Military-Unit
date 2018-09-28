using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Weapon : Unit
    {
        public void MachineGun()
        {
            Console.WriteLine("249 machine guns,");
        }

        public void AssaultRifle()
        {
            Console.WriteLine("M16 assault rifles,");
        }

        public void SniperRifle()
        {
            Console.WriteLine("50. cal sniper rifles.");
        }
    }
}
