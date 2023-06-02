using InterfaceGyakorlas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas.Classes
{
	internal class Vehicle : IDriveable
	{
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vehicle( string brand = "No Brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"A {Brand} típusú autó előre halad {Speed} km/h sebességgel.");
        }

        public void Stop() 
        {
            Console.WriteLine($"A {Brand} típusú autó megállt!");
            Speed = 0;
        }

    }
}
