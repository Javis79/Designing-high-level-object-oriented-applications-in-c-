using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_KB
{
	class Program
	{
		static void Main(string[] args)
		{
			int requiredFood = 0;
			Civilian civ1 = new Civilian();
			Civilian civ2 = new Civilian();
			Civilian civ3 = new Civilian();
			Pikeman pik1 = new Pikeman();
			Pikeman pik2 = new Pikeman();
			Crossbowman cro1 = new Crossbowman();
			Crossbowman cro2 = new Crossbowman();

			List<Civilian> civilians = new List<Civilian>()
			{
				civ1, civ2, civ3
			};

			List<Defender> defenders = new List<Defender>()
			{
				pik1, pik2, cro1, cro2
			};

			List<Crossbowman> crossbowmen = new List<Crossbowman>()
			{
				cro1, cro2
			};

			List<Inhabitant> inhabitants = new List<Inhabitant>();

			inhabitants.AddRange(civilians);
			inhabitants.AddRange(defenders);

			Console.WriteLine("Defenders:");
			foreach (var d in defenders)
			{
				Console.WriteLine(d.ReadyToFight());
			}

			Console.WriteLine("\nCrossbowmen:");
			foreach (var c in crossbowmen)
			{
				Console.WriteLine(c.ReadyToFight());
			}

			Console.WriteLine("\nList of all inhabitants:");
			foreach (var i in inhabitants)
			{
				Console.WriteLine(i);
				Console.WriteLine($"Food supply required: {i.Eat()}");
				requiredFood += i.Eat();
			}
			Console.WriteLine($"\nThere are {inhabitants.Count()} inhabitants and they require {requiredFood} units of food.");
		}
	}
}