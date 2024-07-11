using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper.Business
{
    class CoveredFlaggedSquareState : SquareState
    {

        public override void ToggleFlag(Square square)
        {
            square.State = new CoveredUnFlaggedSquareState();
        }

        public override bool IsCovered
        {
            get { return true; }
        }

        public override bool IsFlagged
        {
            get { return true; }
        }
    }
}
