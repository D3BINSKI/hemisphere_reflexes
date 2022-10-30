using System.Numerics;

namespace WinFormsApp;

public class Vertex
{
    private float _x;
    private float _y;
    private float _z;

    public Vertex(float x, float y, float z, int id)
    {
        _x = x;
        _y = y;
        _z = z;

        Id = id;
    }

    public float X { get => _x; set => _x = value; }
    public float Y { get => _y;
        set => _y = value;
    } 
    public float Z { get => _z;
        set => _z = value;
    }

    public int Id { get; }

    public static Vector3 operator -(Vertex v1, Vertex v2) => 
        new Vector3((float)(v1.X - v2.X), (float)(v1.Y - v2.Y), (float)(v1.Z - v2.Z));

    // public static Vertex operator +(Vertex v, Vector3 vector3) =>
    //     new Vertex(v.X + vector3.X, v.Y + vector3.Y, v.Z + vector3.Z);

    // public static Vertex operator *(Vertex v, float k) => new Vertex(v._x * k, v._y * k, v._z * k);

    public void Scale(float kX, float kY, float kZ)
    {
        X = X * kX;
        Y = Y * kY;
        Z = Z * kZ;
    }
    
    public void Move(float deltaX, float deltaY, float deltaZ)
    {
        X += deltaX;
        Y += deltaY;
        Z += deltaZ;
    }
    
    public bool Equals(Vertex? v)
    {
        if (v is null)
        {
            return false;
        }

        // Optimization for a common success case.
        if (ReferenceEquals(this, v))
        {
            return true;
        }

        // If run-time types are not exactly the same, return false.
        if (GetType() != v.GetType())
        {
            return false;
        }

        // Return true if the fields match.
        // Note that the base class is not invoked because it is
        // System.Object, which defines Equals as reference equality.
        return X.Equals(v.X) && Y.Equals(v.Y) && Z.Equals(v.Z);
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is Vertex other)
        {
            return Equals(other);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_x, _y, _z);
    }
}