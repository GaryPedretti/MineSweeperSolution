using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper.Business
{
    public abstract class Square
    {
        private SquareState state = new CoveredUnFlaggedSquareState();
        private List<Square> neighbors;

        public List<Square> Neighbors
        {
            get { return neighbors; }
            set { neighbors = value; }
        }

        public bool isCovered
        {
            get { return state.IsCovered; }
        }

        public void Uncover()
        {
            state.Uncover(this);
        }

        public bool isFlagged 
        {
            get { return state.IsFlagged; }
        }

        public void ToggleFlag()
        {
            state.ToggleFlag(this);
        }

        internal SquareState State {

            get { return state; }

            set { state = value; } 
        }

        internal abstract void Reveal();
    }
}
