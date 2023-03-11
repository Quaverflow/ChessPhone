namespace ChessPhone.Core.Models;

public readonly struct StepLimit
{
    public readonly int? Value;
    public readonly bool HasLimit;

    public StepLimit(int? value)
    {
        Value = value;
        HasLimit = Value != null;
    }
}