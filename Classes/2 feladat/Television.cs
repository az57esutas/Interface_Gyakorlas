using InterfaceGyakorlas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas.Classes
{
	class Television : IElectronicDevice
	{
		public int Volume { get; set; }

		public void Off()
		{
            Console.WriteLine("A TV ki lett kapcsolva!");
        }

		public void On()
		{
			Console.WriteLine("A TV be lett kapcsolva!");

		}

		public void VolumeDown()
		{
			if (Volume != 0 )
			{
				Volume--;
				Console.WriteLine($"{Volume} Volume - ");

			}
		}

		public void VolumeUp()
		{
			if (Volume != 100)
			{
				Volume++;
				Console.WriteLine($"{Volume} Volume + ");

			}
		}
	}
}
