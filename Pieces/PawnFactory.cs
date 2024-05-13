namespace ChessLogic.Pieces
{
    public class PawnFactory : IPieceFactory
    {
        public Piece CreatePiece(Player color)
        {
            return new Pawn(color);
        }
    }
}