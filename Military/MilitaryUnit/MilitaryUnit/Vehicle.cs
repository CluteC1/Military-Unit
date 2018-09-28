using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Vehicle : Unit
    {
        public void Hmmwv()
        {
            Console.WriteLine("25 Hmmwv's ");
        }

        public void SevenTon()
        {
            Console.WriteLine("15 7 Ton's");
        }

        public void Lvsr()
        {
            Console.WriteLine("5 Lvsr's");
        }
    }
}
