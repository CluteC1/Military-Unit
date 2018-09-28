using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace MilitaryUnit
{
    class Program
    {
        static void MainMenu()
        {
            // MainMenu method is the method I used to call
            //all classes derived from the Unit class
            //The weapon class below derives off of the unit 
            //class and uses methods within the weapons class
            Console.WriteLine("Troops and weapons needed to win a war: ");
            Weapon weapon = new Weapon();
            weapon.UnitSizeStarting("500");
            weapon.AssaultRifle();
            weapon.MachineGun();
            weapon.SniperRifle();
            
            //The vehicle class is called in this method and
            //Calls the different methods within its class
            Console.WriteLine("\nVehicles needed to win the war:");
            Vehicle vehicle = new Vehicle();
            vehicle.Hmmwv();
            vehicle.SevenTon();
            vehicle.Lvsr();

            //The unit class below calls its class and displays it to the 
            // Main menu to be called to be displayed
            Console.WriteLine("\nThe ending results of the war was: ");
            Unit unitsize = new Unit();
            unitsize.UnitSizeEnding("450");
        }

        static void Main()
        {
            //I added in try catch for practice reasons
            try
            {
                //I called my MainMenu method in the Main class so that it
                //will be called to the screen when debugged
                MainMenu();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
