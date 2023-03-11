using ChessPhone.Core.Models;
using MudBlazor;

public class DisplayBox
{
    public Box Box { get; set; }
    public Color Color { get; set; }

    public DisplayBox(Box box, Color color)
    {
        Box = box;
        Color = color;
    }
}