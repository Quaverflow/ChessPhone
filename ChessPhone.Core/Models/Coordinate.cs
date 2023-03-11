namespace ChessPhone.Core.Models;

public readonly struct Coordinate
{
    public readonly int X;
    public readonly int Y;

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static bool operator ==(Coordinate a, Coordinate b) => a.Equals(b);
    public static bool operator !=(Coordinate a, Coordinate b) => !(a == b);
    public bool Equals(Coordinate other) => X == other.X && Y == other.Y;
    public override bool Equals(object? obj) => obj is Coordinate other && Equals(other);
    public override int GetHashCode() => HashCode.Combine(X, Y);
}