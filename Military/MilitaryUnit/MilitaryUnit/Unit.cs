using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Unit
    {
        public void UnitSizeStarting(string sizeOfUnit)
        {
            Console.WriteLine($"Unit of {sizeOfUnit} Marines,");
        }
        public void UnitSizeEnding(string sizeOfUnitEnding)
        {
            Console.WriteLine($"{sizeOfUnitEnding} Marines survived,");
        }
    }
}
