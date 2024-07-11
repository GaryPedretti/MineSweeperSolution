using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper.Business
{
    abstract class SquareState
    {
        public virtual void Uncover(Square square)
        {

        }

        public virtual void ToggleFlag(Square square)
        {

        }

        public abstract bool IsCovered { get; }

        public abstract bool IsFlagged { get; }
    }
}
