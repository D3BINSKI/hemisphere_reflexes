using System.Drawing.Imaging;
using System.Numerics;
using WinFormsApp.GeometryComponents;

namespace WinFormsApp.GraphicTools;

public class ColorGenerator
{
    private Illumination _illumination;
    private Bitmap _objTexture;
    private SurfaceProperties _surface;
    private List<Vertex> _vertices;
    private Color[] _verticesColors;

    public ColorGenerator(Illumination illumination, Bitmap texture, List<Vertex> vertices, SurfaceProperties surface)
    {
        _illumination = illumination;
        _objTexture = texture;
        _surface = surface;
        _vertices = vertices;
        _verticesColors = ComputeColorsInVertices(_vertices);
    }

    private Color[] ComputeColorsInVertices(IReadOnlyList<Vertex> vertices)
    {
        if (vertices.Count < 3)
        {
            throw new ArgumentException($"Expected number of vertices is 3. Number of vertices passed to function was {vertices.Count}");
        }
        var colors = new Color[3];
        for (int i = 0; i < 3; i++)
        {
            colors[i] = CalculateColor(vertices[i]);
        }

        return colors;
    }

    private Color CalculateColor(Vertex vertex)
    {
        var N = vertex.NormalVector;
        var L = Vector3.Normalize(new Vector3((float)(_illumination.Position.X - vertex.X),
            (float)(_illumination.Position.Y - vertex.Y),
            (float)(_illumination.Position.Z - vertex.Z)));
            
        double cosNL = Math.Max(Vector3.Dot(N,L), 0);

        var R = Vector3.Subtract(2 * ((float)cosNL) * N, L);
        double cosVR = Math.Max(R.Z, 0);

        var pixelColor = _objTexture.GetPixel((int)vertex.X, (int)vertex.Y);
        
        var objRedColor =  pixelColor.R / 255.0;
        var objGreenColor = pixelColor.G / 255.0;
        var objBlueColor = pixelColor.B / 255.0;

        var Ir = objRedColor * _illumination.Color.R * (_surface.Kd * cosNL + _surface.Ks * Math.Pow(cosVR, _surface.M));
        Ir = Math.Max(Ir, 0);
        Ir = Math.Min(Ir * 255, 255);
        
        var Ig = objGreenColor * _illumination.Color.G * (_surface.Kd * cosNL + _surface.Ks * Math.Pow(cosVR, _surface.M));
        Ig = Math.Max(Ig, 0);
        Ig = Math.Min(Ig * 255, 255);

        var Ib = objBlueColor * _illumination.Color.B * (_surface.Kd * cosNL + _surface.Ks * Math.Pow(cosVR, _surface.M));
        Ib = Math.Max(Ib, 0);
        Ib = Math.Min(Ib * 255, 255);

        return Color.FromArgb((byte)Ir, (byte)Ig, (byte)Ib);
    }

    public void SetVertices(List<Vertex> vertices)
    {
        _vertices = vertices;
        _verticesColors = ComputeColorsInVertices(_vertices);
    }

    private Color InterpolateColor(float w, float u, float v)
    {
        // p = wV0 + uV1 + vV2 
        var R = Math.Min(_verticesColors[0].R * w + _verticesColors[1].R * u + _verticesColors[2].R * v, 255);
        var G = Math.Min(_verticesColors[0].G * w + _verticesColors[1].G * u + _verticesColors[2].G * v, 255);
        var B = Math.Min(_verticesColors[0].B * w + _verticesColors[1].B * u + _verticesColors[2].B * v, 255);

        return Color.FromArgb((int)R, (int)G, (int)B);
    }

    public Vector3 InterpolateVector(float w, float u, float v)
    {
        return Vector3.Normalize(Vector3.Add(Vector3.Add(_vertices[0].NormalVector * w, _vertices[1].NormalVector * u),
            _vertices[2].NormalVector * v));
    }

    public Color CalculateColorInPoint(int x, int y, Vector3 N)
    {
        var L = Vector3.Normalize(new Vector3((float)(_illumination.Position.X - x),
            (float)(_illumination.Position.Y - y),(float)_illumination.Position.Z));
            
        double cosNL = Math.Max(Vector3.Dot(N,L), 0);

        var R = Vector3.Subtract(2 * ((float)cosNL) * N, L);
        double cosVR = Math.Max(R.Z, 0);

        var pixelColor = _objTexture.GetPixel(x, y);
        
        var objRedColor =  pixelColor.R / 255.0;
        var objGreenColor = pixelColor.G / 255.0;
        var objBlueColor = pixelColor.B / 255.0;

        var Ir = objRedColor * _illumination.Color.R * (_surface.Kd * cosNL + _surface.Ks * Math.Pow(cosVR, _surface.M));
        Ir = Math.Max(Ir, 0);
        Ir = Math.Min(Ir * 255, 255);
        
        var Ig = objGreenColor * _illumination.Color.G * (_surface.Kd * cosNL + _surface.Ks * Math.Pow(cosVR, _surface.M));
        Ig = Math.Max(Ig, 0);
        Ig = Math.Min(Ig * 255, 255);

        var Ib = objBlueColor * _illumination.Color.B * (_surface.Kd * cosNL + _surface.Ks * Math.Pow(cosVR, _surface.M));
        Ib = Math.Max(Ib, 0);
        Ib = Math.Min(Ib * 255, 255);

        return Color.FromArgb((byte)Ir, (byte)Ig, (byte)Ib);
    }

    public Color GetColorInPoint(int x, int y)
    {
        // p = wV0 + uV1 + vV2 
        var v1p = new Vector3((float)(x - _vertices[1].X), (float)(y - _vertices[1].Y), 0);
        var v1v2 = new Vector3((float)(_vertices[2].X - _vertices[1].X), (float)(_vertices[2].Y - _vertices[1].Y), 0);
        var w = Vector3.Cross(v1p, v1v2).Length();
        
        var v1v0 = new Vector3((float)(_vertices[0].X - _vertices[1].X), (float)(_vertices[0].Y - _vertices[1].Y), 0);

        var v = Vector3.Cross(v1p, v1v0).Length();
        
        var v0p = new Vector3((float)(x - _vertices[0].X), (float)(y - _vertices[0].Y), 0);
        var v0v2 = new Vector3((float)(_vertices[2].X - _vertices[0].X), (float)(_vertices[2].Y - _vertices[0].Y), 0);

        var u = Vector3.Cross(v0p, v0v2).Length();
        
        // normalization
        var surface = Vector3.Cross(v0v2, -v1v0).Length();
        w /= surface;
        u /= surface;
        v /= surface;

        return CalculateColorInPoint(x, y, InterpolateVector(w, u, v));
    }
}