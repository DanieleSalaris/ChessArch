using Application.Pieces;

namespace Application.Core
{
    public interface IBoard
    {
        public Boundaries Boundaries { get; }
        public Piece GetPieceAt(Position position);
        public void MovePiece(Position startingPosition, Position endingPosition);
    }
}
