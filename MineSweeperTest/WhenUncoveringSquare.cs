using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MineSweeper.Business
{
    [TestClass]
    public class WhenUncoveringSquare
    {
        [TestMethod]
        public void ShouldDoNothingIfNotCovered()
        {
            NumberSquare square = new NumberSquare();
            square.IncrementValue();
            Assert.IsTrue(square.isCovered);
            square.Uncover();
            Assert.IsFalse(square.isCovered);

            square.Uncover();
            Assert.IsFalse(square.isCovered);
        }

        [TestMethod]
        public void ShouldUncoverNeighborsIfBlank()
        {
            Square square = new NumberSquare();
            List<Square> squares = new List<Square>();
            NumberSquare s1 = new NumberSquare();
            s1.IncrementValue();
            NumberSquare s2 = new NumberSquare();
            s2.IncrementValue();
            NumberSquare s3 = new NumberSquare();
            s3.IncrementValue();
            squares.Add(s1);
            squares.Add(s2);
            squares.Add(s3);
            square.Neighbors = squares;

            square.Uncover();

            Assert.IsFalse(s1.isCovered);
            Assert.IsFalse(s2.isCovered);
            Assert.IsFalse(s3.isCovered);
        }

        [TestMethod]
        public void ShouldEndGameWhenMine()
        {
            Square square = new MineSquare();
            MineSweeperGame.Instance.Initialize(5, 5, 5);
            square.Uncover();
            Assert.IsTrue(MineSweeperGame.Instance.GameOver);
        }

        [TestMethod]
        public void ShouldToggleFlag()
        {
            Square square = new NumberSquare();
            square.ToggleFlag();
            Assert.IsTrue(square.isFlagged);
            square.ToggleFlag();
            Assert.IsFalse(square.isFlagged);
        }

        [TestMethod]
        public void ShouldDoNothingIfFlagged()
        {
            Square square = new NumberSquare();

            square.ToggleFlag();
            square.Uncover();
            Assert.IsTrue(square.isCovered);
        }

        [TestMethod]
        public void ShouldNotFlagUncoveredSquare()
        {
            NumberSquare square = new NumberSquare();
            square.IncrementValue();
            square.Uncover();
            square.ToggleFlag();

            Assert.IsFalse(square.isFlagged);
        }

    }
}
