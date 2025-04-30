using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    interface IStrategy
    {
        bool GetNextMove(List<bool> knownMoves); // use this method to return your next move in game
    }
}
