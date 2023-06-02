using InterfaceGyakorlas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas.Classes._3_feladat
{
	class CanTeleport : ITeleports
	{
		public string teleport()
		{
			return "Teleports Away";
		}
	}
}
