using System.Text;

namespace WinFormsApp;

public class Point2D
{
    private double _x;
    private double _y;

    public Point2D(float x, float y)
    {
        _x = x;
        _y = y;
    }

    public double X => _x;
    public double Y => _y;

    public (double, double) Coordinates
    {
        get => (_x, _y);
        set
        {
            _x = value.Item1;
            _y = value.Item2;
        }
    }
}

public class Point3D
{
    private double _x;
    private double _y;
    private double _z;

    public Point3D(float x, float y, float z) { 
        _x = x; _y = y; _z = z; 
    }

    public double X => _x;
    public double Y => _y;
    public double Z => _z;

    public (double, double, double) Coordinates
    {
        get => (_x, _y, _z);
        set 
        { 
            _x = value.Item1;
            _y = value.Item2;
            _z = value.Item3;
        }
    }

    public void Move(Vector3D vector)
    {
        _x += vector.X;
        _y += vector.Y;
        _z += vector.Z;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"({_x}, {_y}, {_z})");
        return stringBuilder.ToString();
    }

    public static Vector3D operator -(Point3D p1, Point3D p2) => 
        new Vector3D(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
}