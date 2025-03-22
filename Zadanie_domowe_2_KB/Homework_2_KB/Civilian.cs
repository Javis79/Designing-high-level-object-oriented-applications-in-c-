using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_KB
{
	internal class Civilian : Inhabitant
	{
		public override int Eat()
		{
			return 3;
		}
		public override string ToString()
		{
			return "This inhabitant is civilian.";
		}

		public Civilian() { }
	}
}
