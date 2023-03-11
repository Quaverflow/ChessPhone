using ChessPhone.Core.Models;
using ChessPhone.Core.Repositories;
using ChessPhone.Core.Services;

namespace ChessPhone.Core.UnitTests;

public abstract class ChessPieceServiceTestBase
{
    protected ChessPieceService BuildService(int xSize, int ySize)
    {
        var board = new Board
        {
            Boxes = BuildOnlyValidBoxSet(xSize, ySize).ToArray()
        };

        var chessPieceService = new ChessPieceService();
        return chessPieceService;
    }

    protected static ChessPiece SelectPiece(string name)
        => DataProvider.ChessPieces.First(x => x.Name == name);

    private Box BuildValidBox(int x, int y)
        => new()
        {
            Coordinate = new Coordinate(x, y),
            Name = _boxNames.Dequeue(),
            IsValid = true,
            IsValidStart = true
        };

    private IEnumerable<Box> BuildOnlyValidBoxSet(int xCount, int yCount)
    {
        var boxes = new List<Box>();

        for (var x = 0; x < xCount; x++)
        {
            for (var y = 0; y < yCount; y++)
            {
                boxes.Add(BuildValidBox(x, y));
            }
        }

        return boxes;
    }

    private readonly Queue<string> _boxNames = new(new List<string>
    {
        "1", "2", "3", "4",
        "5", "6", "7", "8",
        "9", "0", "a", "b",
        "c", "d", "e" });
}