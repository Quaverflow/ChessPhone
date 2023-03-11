using ChessPhone.Core.Models;

namespace ChessPhone.Core.Repositories;

public interface IChessPieceRepository
{
    IEnumerable<ChessPiece> GetPieces();
}