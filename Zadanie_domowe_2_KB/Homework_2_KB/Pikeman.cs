using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_KB
{
	internal class Pikeman : Defender
	{
		public override int Eat()
		{
			return 7;
		}
		public override string ReadyToFight()
		{
			return "This pikeman is ready to defend castle.";
		}

		public override string ToString()
		{
			return "This inhabitant is pikeman.";
		}

		public Pikeman() { }
	}
}
