namespace Application.Core
{
    internal interface IPiece
    {
        IEnumerable<Position> GetPossibleMoves(Position startingPosition);
    }
}
