using System.Text;

namespace WinFormsApp.GeometryComponents;

public class Point3
{
    private double _x;
    private double _y;
    private double _z;


    public Point3(double x, double y, double z) { 
        _x = x; _y = y; _z = z; 
    }

    protected Point3(Point3 point)
    {
        _x = point.X;
        _y = point.Y;
        _z = point.Z;
    }

    public double X { get => _x; set => _x = value; }
    public double Y { get => _y; set => _y = value; }
    public double Z { get => _z; set => _z = value; }

    public void Move(Vector3D vector)
    {
        _x += vector.X;
        _y += vector.Y;
        _z += vector.Z;
    }

    // TODO Remove after refactoring of finding point coordinates inside face 
    public static double Distance(Point3 p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1._x, 2) + Math.Pow(p2.Y - p1._y, 2));
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"({_x}, {_y}, {_z})");
        return stringBuilder.ToString();
    }

    public static Vector3D operator -(Point3 p1, Point3 p2) => 
        new Vector3D(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
}