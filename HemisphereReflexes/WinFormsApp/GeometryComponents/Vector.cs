namespace WinFormsApp.GeometryComponents;

public class Vector3D
{
    private double _x;
    private double _y;
    private double _z;

    public Vector3D(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    public double X => _x;
    public double Y => _y;
    public double Z => _z;

    public override string ToString()
    {
        return $"[{_x}, {_y}, {_z}]";
    }
}