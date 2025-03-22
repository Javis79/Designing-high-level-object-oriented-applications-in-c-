using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_KB
{
	internal class Crossbowman : Defender
	{
		public override int Eat()
		{
			return 6;
		}

		public override string ReadyToFight()
		{
			return "Crossbowman is ready for a strike.";
		}

		public override string ToString()
		{
			return "This inhabitant is crossbowman.";
		}
		public Crossbowman() { }
	}
}
