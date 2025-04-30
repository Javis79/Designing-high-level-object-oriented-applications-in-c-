using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class StrategyAlwaysFalse : IStrategy
    {
		// placeholder strategy - always betray (always return false)
		public bool GetNextMove(List<bool> knownMoves)
		{
			return false;
		}
	}
}
