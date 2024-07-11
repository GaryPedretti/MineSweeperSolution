using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper.Business
{
    class CoveredUnFlaggedSquareState : SquareState 
    {
        public override void Uncover(Square square)
        {
            square.State = new UncoveredSquareState();
            square.Reveal();
        }

        public override void ToggleFlag(Square square)
        {
            square.State = new CoveredFlaggedSquareState();
        }

        
        public override bool IsCovered { get { return true; } }
        public override bool IsFlagged { get { return false; } }

    }
}
