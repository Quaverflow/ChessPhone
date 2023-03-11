using ChessPhone.Core.Repositories;

namespace ChessPhone.Core.UnitTests;

public class ChessPieceServiceSimplifiedShould : ChessPieceServiceTestBase
{
    [Theory]
    [InlineData(2, 2, 1, 2)]
    [InlineData(2, 2, 2, 12)]
    [InlineData(3, 3, 2, 114)]
    [InlineData(4, 3, 2, 498)]
    [InlineData(4, 3, 4, 5508)]
    public void CalculateSimplifiedScenario_ForQueen(int permutations, int xSize, int ySize, int expectedResult)
    {
        var chessPieceService = BuildService(xSize, ySize);
        var piece = SelectPiece("Queen");

        var result = chessPieceService.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 2, 1, 2)]
    [InlineData(2, 2, 2, 8)]
    [InlineData(3, 3, 2, 54)]
    [InlineData(4, 3, 2, 162)]
    [InlineData(4, 3, 4, 1500)]
    public void CalculateSimplifiedScenario_ForRook(int permutations, int xSize, int ySize, int expectedResult)
    {
        var chessPieceService = BuildService(xSize, ySize);
        var piece = SelectPiece("Rook");

        var result = chessPieceService.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 2, 1, 0)]
    [InlineData(2, 2, 2, 4)]
    [InlineData(3, 3, 2, 12)]
    [InlineData(4, 3, 2, 16)]
    [InlineData(4, 3, 4, 256)]
    public void CalculateSimplifiedScenario_ForBishop(int permutations, int xSize, int ySize, int expectedResult)
    {
        var chessPieceService = BuildService(xSize, ySize);
        var piece = SelectPiece("Bishop");

        var result = chessPieceService.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 2, 1, 2)]
    [InlineData(2, 2, 2, 12)]
    [InlineData(3, 3, 2, 86)]
    [InlineData(4, 3, 2, 326)]
    [InlineData(4, 3, 4, 2240)]
    public void CalculateSimplifiedScenario_ForKing(int permutations, int xSize, int ySize, int expectedResult)
    {
        var chessPieceService = BuildService(xSize, ySize);
        var piece = SelectPiece("King");

        var result = chessPieceService.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 2, 1, 0)]
    [InlineData(2, 2, 2, 0)]
    [InlineData(3, 3, 2, 4)]
    [InlineData(4, 3, 2, 4)]
    [InlineData(4, 3, 4, 164)]
    public void CalculateSimplifiedScenario_ForKnight(int permutations, int xSize, int ySize, int expectedResult)
    {
        var chessPieceService = BuildService(xSize, ySize);
        var piece = SelectPiece("Knight");

        var result = chessPieceService.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }
}