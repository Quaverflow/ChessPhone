using ChessPhone.Core.Enums;
using ChessPhone.Core.Models;

namespace ChessPhone.Core.Helpers;

/// <summary>
/// Contains the necessary math to calculate valid moves
/// </summary>
public static class MoveRules
{
    public static Func<Box, Box, StepLimit, bool> GetPredicate(MoveType moveType)
        => moveType switch
        {
            MoveType.Straight => CanMoveStraight,
            MoveType.Diagonal => CanMoveDiagonal,
            MoveType.LShape => CanMoveLShape,
            _ => throw new ArgumentOutOfRangeException(nameof(moveType), moveType, null)
        };

    private static bool CanMoveStraight(Box current, Box next, StepLimit limit)
    {
        if (!IsWithinRange(current, next, limit))
        {
            return false;
        }

        return IsWithinRange(current, next, limit)
               && next.Coordinate.X == current.Coordinate.X
               || next.Coordinate.Y == current.Coordinate.Y;
    }

    private static bool CanMoveDiagonal(Box current, Box next, StepLimit limit)
        => IsWithinRange(current, next, limit)
           && SubtractMinFromMax(current.Coordinate.X, next.Coordinate.X)
           == SubtractMinFromMax(current.Coordinate.Y, next.Coordinate.Y);

    private static bool CanMoveLShape(Box current, Box next, StepLimit limit)
    {
        if (!IsWithinRange(current, next, limit))
        {
            return false;
        }

        var differenceOnX = SubtractMinFromMax(current.Coordinate.X, next.Coordinate.X);
        var differenceOnY = SubtractMinFromMax(current.Coordinate.Y, next.Coordinate.Y);

        return Math.Max(differenceOnX, differenceOnY) == 2 && Math.Min(differenceOnX, differenceOnY) == 1;
    }

    private static bool IsWithinRange(Box current, Box next, StepLimit limit)
    {
        if (!limit.HasLimit)
        {
            return true;
        }

        var differenceOnX = SubtractMinFromMax(current.Coordinate.X, next.Coordinate.X);
        var differenceOnY = SubtractMinFromMax(current.Coordinate.Y, next.Coordinate.Y);
        return SubtractMinFromMax(differenceOnX, differenceOnY) <= limit.Value;
    }

    private static int SubtractMinFromMax(int a, int b)
    => Math.Max(a, b) - Math.Min(a, b);
}