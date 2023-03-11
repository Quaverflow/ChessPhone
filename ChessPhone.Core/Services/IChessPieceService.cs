using ChessPhone.Core.Models;

namespace ChessPhone.Core.Services;

public interface IChessPieceService
{
    long CalculateNumberOfCombinations(ChessPiece piece, Board board, int limit);
    
    /// <summary>
    /// Only for display purposes
    /// </summary>
    /// <param name="piece"></param>
    /// <param name="board"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    string GetRandomCombination(ChessPiece piece, Board board, int limit);
}