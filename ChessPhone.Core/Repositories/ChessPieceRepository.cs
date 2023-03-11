using ChessPhone.Core.Models;

namespace ChessPhone.Core.Repositories;

public class ChessPieceRepository : IChessPieceRepository
{
    public IEnumerable<ChessPiece> GetPieces()
        => DataProvider.ChessPieces;
}