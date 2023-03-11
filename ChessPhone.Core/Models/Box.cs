namespace ChessPhone.Core.Models;

public class Box
{
    public required string Name { get; set; }
    public Coordinate Coordinate { get; set; }

    public bool IsValid { get; set; }
    public bool IsValidStart { get; set; }
}