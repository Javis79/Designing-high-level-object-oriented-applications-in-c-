using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class StrategyRepeater : IStrategy
    {
		// placeholder strategy - always repeats previous move of second player 
		private static Random rng = new Random();
		public bool GetNextMove(List<bool> knownMoves)
		{
			if (knownMoves.Count == 0)
			{
				return rng.NextDouble() < 0.5;
			}

			return knownMoves[knownMoves.Count - 1];
		}

	}
}
