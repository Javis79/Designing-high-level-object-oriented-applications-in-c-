using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class StrategyCounter : IStrategy
    {
		// placeholder strategy - always betray after being batrayed (always return false)
		private static Random rng = new Random();
		public bool GetNextMove(List<bool> knownMoves)
		{
			if(knownMoves.Count == 0)
			{
				return rng.NextDouble() < 0.5;
			}

			if (knownMoves[knownMoves.Count - 1] == false)
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
