using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_KB
{
	abstract class Defender : Inhabitant, IReady
	{
		public override int Eat()
		{
			return 5;
		}
		public override string ToString()
		{
			return "This inhabitant is defender.";
		}
		public abstract string ReadyToFight();
	}
}
