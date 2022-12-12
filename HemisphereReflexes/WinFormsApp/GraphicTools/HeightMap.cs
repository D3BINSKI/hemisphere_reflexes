using System.Numerics;
using ObjParser.Types;

namespace WinFormsApp.GraphicTools;

public class HeightMap
{
    private Bitmap _bitmap;
    public int Width => _bitmap.Width;
    public int Height => _bitmap.Height;
    
    public HeightMap(Image heightMapImage, Size size)
    {
        _bitmap = new Bitmap(heightMapImage, size);
    }

    public void Resize(Size newSize)
    {
        _bitmap = new Bitmap(_bitmap, newSize);
    }

    public Vector3 GetNormalVector(GeometryComponents.Vertex vertex)
    {
        var pixelColor = _bitmap.GetPixel((int)vertex.X, (int)vertex.Y);
        var nextYPixelColor = _bitmap.GetPixel((int)vertex.X, (int)(vertex.Y + 1));
        var nextXPixelColor = _bitmap.GetPixel((int)(vertex.X + 1), (int)vertex.Y);

        var deltaX = nextXPixelColor.R - pixelColor.R;
        var deltaY = nextYPixelColor.R - pixelColor.R;
        
        var Np = vertex.NormalVector;

        var B = Vector3.Multiply(Np, new Vector3(0, 0, 1));
        if (Np.X == 0 && Np.Y == 0 && Math.Abs(Np.Z - 1.0) < Double.Epsilon)
        {
            B = new Vector3(0, 1, 0);
        }

        var T = Vector3.Multiply(B, Np);

        var D = Vector3.Add(Vector3.Multiply(deltaX, T), Vector3.Multiply(deltaY, B));

        return Vector3.Normalize(Vector3.Add(vertex.NormalVector, Vector3.Multiply((float)0.5, D)));
    }

    public Vector3 GetNormalVector(Vector3 N, int x, int y)
    {
        var pixelColor = _bitmap.GetPixel(x, y);
        var nextYPixelColor = _bitmap.GetPixel(x, y+1);
        var nextXPixelColor = _bitmap.GetPixel(x+1, y);

        var deltaX = nextXPixelColor.R - pixelColor.R;
        var deltaY = nextYPixelColor.R - pixelColor.R;
        
        var Np = N;

        var B = Vector3.Multiply(Np, new Vector3(0, 0, 1));
        if (Np.X == 0 && Np.Y == 0 && Math.Abs(Np.Z - 1.0) < Double.Epsilon)
        {
            B = new Vector3(0, 1, 0);
        }

        var T = Vector3.Multiply(B, Np);

        var D = Vector3.Add(Vector3.Multiply(deltaX, T), Vector3.Multiply(deltaY, B));

        return Vector3.Normalize(Vector3.Add(Np, Vector3.Multiply((float)0.5, D)));

    }
}