using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper.Business
{
    class UncoveredSquareState : SquareState
    {

        public override bool IsCovered { get { return false; } }
        public override bool IsFlagged { get { return false; } }
    }
}
