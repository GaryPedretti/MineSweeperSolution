using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper.Business
{
    public class MineSquare : Square
    {
        internal override void Reveal()
        {
            MineSweeperGame.Instance.EndGame();
        }

        public override string ToString()
        {
            return "*";
        }
    }
}
