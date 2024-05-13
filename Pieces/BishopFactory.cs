namespace ChessLogic.Pieces
{
    public class BishopFactory : IPieceFactory
    {
        public Piece CreatePiece(Player color)
        {
            return new Bishop(color);
        }
    }
}