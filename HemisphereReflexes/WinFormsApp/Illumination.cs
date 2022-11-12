using System.Numerics;
using WinFormsApp.GraphicComponents;

namespace WinFormsApp;

public enum LuminanceType
{
    Direct,
    General
}

public class Illumination
{
    private Color _color;

    public Color Color { get => _color; }
    
    public Point3 Position { get; }


    public Illumination(Point3 point, Color color)
    {
        Position = point;
        _color = color;
    }
    
}