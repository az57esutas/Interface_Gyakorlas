using InterfaceGyakorlas.Classes;
using InterfaceGyakorlas.Classes._3_feladat;
using InterfaceGyakorlas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region 1. feladat:
			Console.WriteLine("1. feladat: Autó példány és interfész kipróbálása");
			Vehicle skoda = new Vehicle("Skoda", 4, 200);

			//Tesztelés
			if (skoda is IDriveable)
			{
				skoda.Move();
				skoda.Stop();
			}
			else Console.WriteLine($"A {skoda.Brand} típusú autó nem vezethető!\n");

            #endregion

            #region 2. feladat:
            Console.WriteLine();
            Console.WriteLine("2. feladat: Televíziós példakód, távirányítás interfésszel");
			IElectronicDevice TV = TVRemote.GetDevice();
			
			PowerButton powBut = new PowerButton(TV);
			VolumeButton volBut = new VolumeButton(TV);

			//vezérlés tesztelése:
			//Be/Ki kapcsolás:
			powBut.Execute();
			powBut.Undo();
			powBut.Execute();
			powBut.Undo();

			//Hangerő növelése:
			volBut.Execute();
			volBut.Execute();
			volBut.Execute();
			volBut.Execute();


			//Hangerő csökkentése:
			volBut.Undo(); 
			volBut.Undo();
			volBut.Undo();
			volBut.Undo();
			volBut.Undo();
			volBut.Undo();
			volBut.Undo();

            #endregion

            #region 3. feladat:
            Console.WriteLine("");
            Console.WriteLine("3.feladat: Egy harcos játék példa interfésszel...");

			Warrior thor = new Warrior("Thor", 100, 26, 10);
			MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50);
			
			Battle.StartFight(thor, loki);



			#endregion
			Console.ReadKey();
		 }
		
	}
}
