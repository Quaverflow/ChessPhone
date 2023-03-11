using ChessPhone.Core.Repositories;
using ChessPhone.Core.Services;

namespace ChessPhone.Core.UnitTests;

public class ChessPieceServiceShould : ChessPieceServiceTestBase
{
    [Theory]
    [InlineData(1, 8)]
    [InlineData(2, 43)]
    [InlineData(3, 227)]
    public void CalculateForSelectedNumberOfPermutations_RealBoard_King(int permutations, int expectedResult)
    {
        var service = new ChessPieceService();
        var piece = SelectPiece("King");

        var result = service.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(1, 8)]
    [InlineData(2, 55)]
    [InlineData(3, 367)]
    public void CalculateForSelectedNumberOfPermutations_RealBoard_Queen(int permutations, int expectedResult)
    {
        var service = new ChessPieceService();
        var piece = SelectPiece("Queen");

        var result = service.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(1, 8)]
    [InlineData(2, 16)]
    [InlineData(3, 35)]
    public void CalculateForSelectedNumberOfPermutations_RealBoard_Knight(int permutations, int expectedResult)
    {
        var service = new ChessPieceService();
        var piece = SelectPiece("Knight");

        var result = service.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(1, 8)]
    [InlineData(2, 20)]
    [InlineData(3, 49)]
    public void CalculateForSelectedNumberOfPermutations_RealBoard_Bishop(int permutations, int expectedResult)
    {
        var service = new ChessPieceService();
        var piece = SelectPiece("Bishop");

        var result = service.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(1, 8)]
    [InlineData(2, 35)]
    [InlineData(3, 148)]
    public void CalculateForSelectedNumberOfPermutations_RealBoard_Rook(int permutations, int expectedResult)
    {
        var service = new ChessPieceService();
        var piece = SelectPiece("Rook");

        var result = service.CalculateNumberOfCombinations(piece, DataProvider.Board, permutations);
        Assert.Equal(expectedResult, result);
    }
}