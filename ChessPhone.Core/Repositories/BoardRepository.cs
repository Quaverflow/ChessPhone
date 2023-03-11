using ChessPhone.Core.Models;

namespace ChessPhone.Core.Repositories;

public class BoardRepository : IBoardRepository
{
    public Board GetBoard()
    {
        return DataProvider.Board;
    }
}