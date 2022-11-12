namespace WinFormsApp.GraphicTools;

public class AETPointer : IComparable<AETPointer>
{
    public readonly int YMax;
    private double _x;
    private readonly double _m;

    public AETPointer(int yMax, double x, double m)
    {
        this.YMax = yMax;
        this._x = x;
        _m = m == 0 ? double.MaxValue : 1.0/m;
    }
    
    public int X => (int)Math.Round(_x);

    public void UpdateX()
    {
        _x = Math.Abs(_m - Geometry.Infinity) < 1e-7 ? _x : _x + _m;
    }
    
    public int CompareTo(AETPointer? other)
    {
        var xCmp = _x.CompareTo(other?._x);
        return _x == 0 ? YMax.CompareTo(other?.YMax) : xCmp;
    }
}