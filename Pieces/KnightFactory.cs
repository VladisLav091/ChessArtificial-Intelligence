namespace ChessLogic.Pieces
{
    public class KnightFactory : IPieceFactory
    {
        public Piece CreatePiece(Player color)
        {
            return new Knight(color);
        }
    }
}