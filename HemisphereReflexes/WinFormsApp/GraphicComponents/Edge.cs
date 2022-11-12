namespace WinFormsApp.GraphicComponents;

public class Edge
{
    private Vertex _v1;
    private Vertex _v2;
    private double _slope;

    public Vertex V1 => _v1;
    public Vertex V2 => _v2;

    public double Slope => _slope;

    public Edge(Vertex v1, Vertex v2)
    {
        if (v1.Id < v2.Id)
        {
            _v1 = v1;
            _v2 = v2;
        }
        else
        {
            _v1 = v2;
            _v2 = v1;
        }

        _slope = CountSlope(this);
    }
    
    public double CountSlope(Edge edge)
    {
        var dx = edge.V2.X - edge.V1.X;
        var dy = edge.V2.Y - edge.V1.Y;
        var m = Math.Abs(dx) < Geometry.Eps ? Geometry.Infinity : dy / dx;

        return m;
    }

    public void DrawXY(Graphics graphics)
    {
        graphics.DrawLine(Pens.Black, (int)V1.X, (int)V1.Y, 
            (int)V2.X, (int)V2.Y);
    }
    
    public void DrawXZ(Graphics graphics)
    {
        graphics.DrawLine(Pens.Black, (int)V1.X, (int)V1.Z, 
            (int)V2.X, (int)V2.Z);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 13;
            hash = (hash * 7) + V1.GetHashCode();
            hash = (hash * 7) + V2.GetHashCode();
            
            return hash;
        }
    }
    
    public bool Equals(Edge? e)
    {
        if (e is null)
        {
            return false;
        }

        // Optimization for a common success case.
        if (ReferenceEquals(this, e))
        {
            return true;
        }

        // If run-time types are not exactly the same, return false.
        if (GetType() != e.GetType())
        {
            return false;
        }

        // Return true if the fields match.
        // Note that the base class is not invoked because it is
        // System.Object, which defines Equals as reference equality.
        return ((_v1.Equals(V1)) && (_v2.Equals(e.V2))) || ((_v2.Equals(e.V1)) && (_v1.Equals(e.V2)));
    }
    
    public override bool Equals(object? obj)
    {
        Edge? other = obj as Edge;
        if (other != null)
        {
            return Equals(other);
        }
        else
        {
            return false;
        }
    }
}