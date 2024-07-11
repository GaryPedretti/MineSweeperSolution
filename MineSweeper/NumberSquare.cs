using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper.Business
{
    public class NumberSquare : Square
    {
        private int value;

        public int Value
        {
            get { return this.value; }
        }

        public void IncrementValue()
        {
            value++;
        }

        internal override void Reveal()
        {
            if (IsBlank())
            {
                foreach (Square neighbor in Neighbors)
                {
                    neighbor.Uncover();
                }
            }

            MineSweeperGame.Instance.CheckForWin();
        }

        private bool IsBlank()
        {
            return value == 0;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
