using ChessPhone.Core.Enums;

namespace ChessPhone.Core.Models;

public record ChessPiece
{
    public required string Name { get; set; }
    public Direction AllowedDirections { get; set; }
    public required MoveType[] AllowedMoveTypes { get; set; }
    public StepLimit StepLimit { get; set; } = new();
}