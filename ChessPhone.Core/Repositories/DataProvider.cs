using ChessPhone.Core.Models;
using static ChessPhone.Core.Enums.MoveType;
using static ChessPhone.Core.Enums.Direction;

namespace ChessPhone.Core.Repositories;

/// <summary>
/// Audaciously pretends to be a database
/// </summary>
public static class DataProvider
{
    public static readonly Board Board = new Board
    {
        Boxes = new[]
        {
            new Box { Name = "1", IsValid = true, IsValidStart = false, Coordinate = new Coordinate(0,0) },
            new Box { Name = "2", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(1,0)  },
            new Box { Name = "3", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(2,0)  },
            new Box { Name = "4", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(0,1)  },
            new Box { Name = "5", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(1,1)  },
            new Box { Name = "6", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(2,1)  },
            new Box { Name = "7", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(0,2)  },
            new Box { Name = "8", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(1,2)  },
            new Box { Name = "9", IsValid = true, IsValidStart = true, Coordinate = new Coordinate(2,2)  },
            new Box { Name = "*", IsValid = false, IsValidStart = false, Coordinate = new Coordinate(0,3)  },
            new Box { Name = "0", IsValid = true, IsValidStart = false, Coordinate = new Coordinate(1,3)  },
            new Box { Name = "#", IsValid = false, IsValidStart = false, Coordinate = new Coordinate(2,3)   },
        }
    };

    public static readonly ChessPiece[] ChessPieces = 
    {
        new()
        {
            Name = "Pawn",
            AllowedDirections = ForwardOnly,
            AllowedMoveTypes = new[] { Straight },
            StepLimit = new StepLimit(1)
        },
        new()
        {
            Name = "Rook",
            AllowedDirections = AnyDirection,
            AllowedMoveTypes = new[] { Straight }
        },
        new()
        {
            Name = "Knight",
            AllowedDirections = AnyDirection,
            AllowedMoveTypes = new[] { LShape },
        },
        new()
        {
            Name = "Bishop",
            AllowedDirections = AnyDirection,
            AllowedMoveTypes = new[] { Diagonal }
        },
        new()
        {
            Name = "Queen",
            AllowedDirections = AnyDirection,
            AllowedMoveTypes = new[] { Straight, Diagonal }
        },
        new()
        {
            Name = "King",
            AllowedDirections = AnyDirection,
            AllowedMoveTypes = new[] { Straight, Diagonal },
            StepLimit = new StepLimit(1)
        },
    };
}