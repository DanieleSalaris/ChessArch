
using Application.Core;

namespace Application.Pieces
{
    public abstract class Piece : IPiece
    {
        protected IBoard Board { get; init; }
        public abstract string Label { get; }

        public abstract IEnumerable<Position> GetPossibleMoves(Position startingPosition);

        public override string ToString()
        {
            return Label;
        }
    }
}
