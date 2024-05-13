namespace ChessLogic.Pieces
{
    public class QueenFactory : IPieceFactory
    {
        public Piece CreatePiece(Player color)
        {
            return new Queen(color);
        }
    }
}