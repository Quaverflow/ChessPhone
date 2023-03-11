namespace ChessPhone.Core.Models;

public class MoveTree
{
    private readonly IReadOnlyDictionary<string, Box[]> _allValidMoves;
    private readonly int _currentDepth;
    private readonly int _maxDepth;

    public MoveTree(IReadOnlyDictionary<string, Box[]> allValidMoves, Box box, int currentDepth, int maxDepth)
    {
        _allValidMoves = allValidMoves;
        _currentDepth = currentDepth + 1;
        _maxDepth = maxDepth;
        Box = box;
    }

    public Box Box { get; set; }
    public MoveTree[] Available
        => _maxDepth == _currentDepth
            ? Array.Empty<MoveTree>()
            : _allValidMoves[Box.Name]
                .Select(x => new MoveTree(_allValidMoves, x, _currentDepth, _maxDepth))
                .ToArray();

}