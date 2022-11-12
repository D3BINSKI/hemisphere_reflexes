using System.Numerics;
using WinFormsApp.GeometryComponents;

namespace WinFormsApp;

public enum LuminanceType
{
    Direct,
    General
}

public class Illumination
{
    private (double R, double G, double B) _color;

    public (double R, double G, double B) Color => _color;

    public Point3 Position { get; }


    public Illumination(Point3 point, Color color)
    {
        Position = point;
        _color = ((double R, double G, double B))(color.R/255.0, color.G/255.0, color.B/255.0);
    }
    
}