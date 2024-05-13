namespace ChessLogic.Pieces
{
    public class RookFactory : IPieceFactory
    {
        public Piece CreatePiece(Player color)
        {
            return new Rook(color);
        }
    }
}