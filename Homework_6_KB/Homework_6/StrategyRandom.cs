using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class StrategyRandom : IStrategy
    {
		// placeholder strategy - randomly selects what to do (50/50)

		private static Random rng = new Random();
		public bool GetNextMove(List<bool> knownMoves)
		{
			return rng.NextDouble() < 0.5;
		}
	}
}
