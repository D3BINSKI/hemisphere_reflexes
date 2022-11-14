using System.Diagnostics;
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
    private bool _isMovingRight;
    private int _radius;
    private Point _rotationCenter;
    private (double R, double G, double B) _color;

    public (double R, double G, double B) Color => _color;

    public Point3 Position { get; }


    public Illumination(Point3 point, Color color, Point center, int radius)
    {
        Position = point;
        _color = (color.R/255.0, color.G/255.0, color.B/255.0);
        _isMovingRight = true;
        _radius = radius;
        _rotationCenter = center;
    }

    public void Rotate()
    {
        switch (_isMovingRight)
        {
            case true:
                Position.X+=15;
                Position.Y = -Math.Sqrt(Math.Max(_radius * _radius - Math.Pow(Position.X - _rotationCenter.X, 2), 0)) + _rotationCenter.Y;
                break;
            case false:
                Position.X-=15;
                Position.Y = Math.Sqrt(Math.Max(_radius * _radius - Math.Pow(Position.X - _rotationCenter.X, 2), 0)) + _rotationCenter.Y;
                break;
        }

        if (Position.X >= _rotationCenter.X + _radius)
        {
            _isMovingRight = false;
        }
        else if (Position.X <= _rotationCenter.X - _radius)
        {
            _isMovingRight = true;
        }
    }

    public void ChangeHeight(double newHeight)
    {
        Position.Z = newHeight;
    }
    
}