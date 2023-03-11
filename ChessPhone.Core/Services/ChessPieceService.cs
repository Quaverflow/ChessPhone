using ChessPhone.Core.Enums;
using ChessPhone.Core.Models;

namespace ChessPhone.Core.Services;

public class ChessPieceService : IChessPieceService
{
    public long CalculateNumberOfCombinations(ChessPiece piece, Board board, int limit) 
        => GetCombinations(piece, board, limit).LongCount();

    public IEnumerable<string> GetCombinations(ChessPiece piece, Board board, int limit)
    {

        var results = new List<string>();
        if (piece.AllowedDirections != Direction.ForwardOnly)
        {
            var availableMoves = GetAvailableMovesByBox(piece, board);

            var startingBoxes = GetAvailableStartingPoints(board);

            foreach (var startingBox in startingBoxes)
            {
                var resultByStartingPoint = new List<string>();
                var moveTree = new MoveTree(availableMoves, startingBox, 0, limit);
                GetCombinations(moveTree, startingBox.Name, limit, resultByStartingPoint);

                results.AddRange(resultByStartingPoint);
            }
        }

        return results;
    }

    private static void GetCombinations(MoveTree tree, string number, int limit, ICollection<string> result)
    {
        var next = tree.Available;
        if (number.Length == limit)
        {
            result.Add(number);
        }

        foreach (var currentTree in next)
        {
            GetCombinations(currentTree, number + currentTree.Box.Name, limit, result);
        }
    }

    private Dictionary<string, Box[]> GetAvailableMovesByBox(ChessPiece piece, Board board)
        => board.Boxes
            .Where(x => x.IsValid)
            .ToDictionary(x => x.Name,
                x => GetAllAvailableNext(board, x, piece)
                    .ToArray());

    private IEnumerable<Box> GetAllAvailableNext(Board board, Box current, ChessPiece piece)
    {
        var rules = piece.AllowedMoveTypes.Select(MoveRules.GetPredicate);
        return FilterBoxesByPredicate(board, current, piece, rules);
    }

    private IEnumerable<Box> FilterBoxesByPredicate(Board board, Box current, ChessPiece piece,
        IEnumerable<Func<Box, Box, StepLimit, bool>> rules)
        => rules.SelectMany(obeysRule => board.Boxes
            .Where(next => next.IsValid
                           && next.Coordinate != current.Coordinate
                           && obeysRule(current, next, piece.StepLimit)));

    private IEnumerable<Box> GetAvailableStartingPoints(Board board)
    {
        var startingPoints = board.Boxes.Where(x => x.IsValidStart).ToArray();
        if (!startingPoints.Any())
        {
            throw new InvalidOperationException("No starting point was provided");
        }

        return startingPoints;
    }
}