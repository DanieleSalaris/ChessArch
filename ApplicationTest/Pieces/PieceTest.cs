using Application.Core;
using Application.Pieces;
using NUnit.Framework;

namespace ApplicationTest.Pieces
{ 
    [TestFixture]
    internal class PieceTest
    {
        private Piece cut;

        [Test]
        [TestCase("Abc")]
        [TestCase("")]
        public void ToString_ShallReturnLabelValue(string arg)
        {
            cut = new PieceImpl() { L = arg };

            Assert.That(cut.ToString(), Is.EqualTo(arg));
        }
        
    }

    internal class PieceImpl : Piece
    {
        public string L = "";
        public override string Label => L;

        public override IEnumerable<Position> GetPossibleMoves(Position startingPosition)
        {
            throw new NotImplementedException();
        }
    }
}
