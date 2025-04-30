using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class StrategyGrudger : IStrategy
    {
		// placeholder strategy - once betrayed starts betraying
		private static Random rng = new Random();
		public bool GetNextMove(List<bool> knownMoves)
		{
			if (knownMoves.Count == 0)
			{
				return rng.NextDouble() < 0.5;
			}

			if (knownMoves.Contains(false))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
