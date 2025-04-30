using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class StrategyForgiving : IStrategy
    {
		// placeholder strategy - if second player betrays, this doesn't betray right away
		private static Random rng = new Random();
		public bool GetNextMove(List<bool> knownMoves)
		{
			if(knownMoves.Count == 0) { 
				return rng.NextDouble() < 0.5; 
			}

			if (knownMoves.Count >= 2 && knownMoves[knownMoves.Count - 1] == false && knownMoves[knownMoves.Count - 2] == true)
			{
				return true;
			}

			return knownMoves[knownMoves.Count - 1];
		}
	}
}
