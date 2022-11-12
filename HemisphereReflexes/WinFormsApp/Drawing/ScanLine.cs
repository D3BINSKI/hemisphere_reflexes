using WinFormsApp.GraphicComponents;
using System.Collections;
namespace WinFormsApp.Drawing;

public class ScanLine
{
    private List<AETPointer>[] ETPointers;
    private List<AETPointer> AETPointers;
    private int _y;
    private int edgesCount;

    public int Y => _y;

    public ScanLine(List<Edge> edges)
    {
        ETPointers = new List<AETPointer>[1500];
        AETPointers = new List<AETPointer>();
        edgesCount = edges.Count();

        int globalYMin = 1500;
        foreach (var edge in edges)
        {
            if (Math.Min(edge.V1.Y, edge.V2.Y) < globalYMin) globalYMin = (int)Math.Min(edge.V1.Y, edge.V2.Y);
        }
        foreach (var edge in edges)
        {
            int yMin = edge.V1.Y < edge.V2.Y ? (int)edge.V1.Y : (int)edge.V2.Y;
            if (edge.Slope == 0)
            {
                edgesCount--;
                continue;
            }
            if (ETPointers[yMin] is null)
            {
                ETPointers[yMin] = new List<AETPointer>();
            }
            ETPointers[yMin].Add(new AETPointer((int)Math.Max(edge.V1.Y, edge.V2.Y),
                edge.V1.Y < edge.V2.Y ? edge.V1.X : edge.V2.X, edge.Slope));
            ETPointers[yMin].Sort();
        }

        _y = globalYMin;
    }
    

    public IEnumerable<int> IntersectionPoints => AETPointers.Select(pointer => pointer.X);

    public bool IsEnd => !(AETPointers.Any() || edgesCount != 0);
    
    public void UpdateAet()
    {
        if (ETPointers[_y] is not null)
        {
            foreach (var pointer in ETPointers[_y])
            {
                edgesCount--;
                AETPointers.Add(pointer);
            }
        }

        AETPointers.RemoveAll(pointer => pointer.yMax <= _y);
        
        if(AETPointers.Count()>2)Console.WriteLine("3 edges are active");
        _y += 1;
        foreach (var pointer in AETPointers)
        {
            pointer.UpdateX();
        }
        AETPointers.Sort();

    }
}

public class AETPointer : IComparable<AETPointer>
{
    public int yMax;
    public double x;
    public double _m;

    public AETPointer(int yMax, double x, double m)
    {
        this.yMax = yMax;
        this.x = x;
        _m = m == 0 ? double.MaxValue : 1.0/m;
    }
    
    public int X => (int)Math.Round(x);

    public void UpdateX()
    {
        x = Math.Abs(_m - Geometry.Infinity) < 1e-7 ? x : x + _m;
    }
    
    public int CompareTo(AETPointer? other)
    {
        var xCmp = x.CompareTo(other?.x);
        return x == 0 ? yMax.CompareTo(other?.yMax) : xCmp;
    }
}