namespace ChessLogic.Pieces
{
    public class KingFactory : IPieceFactory
    {
        public Piece CreatePiece(Player color)
        {
            return new King(color);
        }
    }
}