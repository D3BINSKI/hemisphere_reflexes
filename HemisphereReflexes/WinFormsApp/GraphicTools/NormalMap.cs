using System.Drawing.Drawing2D;
using System.Numerics;
using WinFormsApp.GeometryComponents;

namespace WinFormsApp.GraphicTools;

public class NormalMap
{
    private Bitmap _bitmap;
    public NormalMap(Image normalMap, Size size)
    {
        _bitmap = new Bitmap(normalMap, size.Width, size.Height);
    }

    public void Resize(Size newSize)
    {
        _bitmap = new Bitmap(_bitmap, newSize);
    }

    public Vector3 GetVector(int x, int y)
    {
        var pixelColor = _bitmap.GetPixel(x, y);
        return Vector3.Normalize(new Vector3(
            (float)GetVectorComponent(pixelColor.R),
            (float)GetVectorComponent(pixelColor.G),
            (float)Math.Max(GetVectorComponent(pixelColor.B), 0)));
    }

    public double GetVectorComponent(byte value)
    {
        return (value - 127.0) / 255.0;
    }

    public Vector3 GetNormalVector(Vertex vertex)
    {
        var Nt = GetVector((int)vertex.X, (int)vertex.Y);
        var Np = vertex.NormalVector;
        var B = Vector3.Multiply(Np, new Vector3(0, 0, 1));
        if (Np.X == 0 && Np.Y == 0 && Math.Abs(Np.Z - 1.0) < Double.Epsilon)
        {
            B = new Vector3(0, 1, 0);
        }

        var T = Vector3.Multiply(B, Np);

        var M = new Matrix4x4(
            T.X, B.X, Np.X, 0,
            T.Y, B.Y, Np.Y, 0,
            T.Z, B.Z, Np.Z, 0,
            0, 0, 0, 1);

        return new Vector3(
            M.M11 * Nt.X + M.M12 * Nt.Y + M.M13 * Nt.Z,
            M.M21 * Nt.X + M.M22 * Nt.Y + M.M23 * Nt.Z,
            M.M31 * Nt.X + M.M32 * Nt.Y + M.M33 * Nt.Z);
    }

    public Vector3 GetNormalVector(Vector3 N, int x, int y)
    {
        var Nt = GetVector(x, y);
        var Np = N;
        var B = Vector3.Multiply(Np, new Vector3(0, 0, 1));
        if (Np.X == 0 && Np.Y == 0 && Math.Abs(Np.Z - 1.0) < Double.Epsilon)
        {
            B = new Vector3(0, 1, 0);
        }

        var T = Vector3.Multiply(B, Np);

        var M = new Matrix4x4(
            T.X, B.X, Np.X, 0,
            T.Y, B.Y, Np.Y, 0,
            T.Z, B.Z, Np.Z, 0,
            0, 0, 0, 1);

        return new Vector3(
            M.M11 * Nt.X + M.M12 * Nt.Y + M.M13 * Nt.Z,
            M.M21 * Nt.X + M.M22 * Nt.Y + M.M23 * Nt.Z,
            M.M31 * Nt.X + M.M32 * Nt.Y + M.M33 * Nt.Z);
    }
}