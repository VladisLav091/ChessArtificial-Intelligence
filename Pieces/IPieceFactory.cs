namespace ChessLogic.Pieces
{
    public interface IPieceFactory
    {
        Piece CreatePiece(Player color);
    }
}