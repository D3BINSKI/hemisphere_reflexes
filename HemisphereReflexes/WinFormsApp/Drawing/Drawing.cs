using System.Configuration;
using System.Numerics;
using WinFormsApp.GraphicComponents;

namespace WinFormsApp.Drawing;

public class Drawing
{
    private int _colorCount = 0;
    public Drawing()
    {
    }
    
    public void FillPolygon(Face face, Bitmap textureBitmap, Bitmap drawingBitmap, Illumination illumination, double kd, double ks, double m)
    {
        ScanLine scanLine = new ScanLine(face.Edges);
        
        var vertices = face.Vertices;
        Color[] verticesColors = new Color[3];

        for (int i = 0; i < vertices.Count(); i++)
        {
            var L = Vector3.Normalize(new Vector3((float)(illumination.Position.X - vertices[i].X),
                (float)(illumination.Position.Y - vertices[i].Y),
                (float)(illumination.Position.Z - vertices[i].Z)));

            verticesColors[i] = CalculateColor(vertices[i].NormalVector, L,
                textureBitmap.GetPixel((int)vertices[i].X, (int)vertices[i].Y),
                illumination.Color, kd, ks, m);
        };

        while (!scanLine.IsEnd)
        {
            scanLine.UpdateAet();

            var intersectionPoints = scanLine.IntersectionPoints.ToList();
            if (intersectionPoints.Count() > 1)
            {
                for (int x = intersectionPoints[0]; x < intersectionPoints[1]; x++)
                {
                    drawingBitmap.SetPixel(x, scanLine.Y, InterpolateColor(vertices, verticesColors, x, scanLine.Y));
                }

                _colorCount++;
            }
        }
    }

    public Color InterpolateColor(List<Vertex> vertices, Color[] colors, int x, int y)
    {
        var p = new Point(x, y);
        Vector3 distancesVector = new Vector3(
            (float)Point3.Distance(vertices[0], p), 
            (float)Point3.Distance(vertices[1], p),
            (float)Point3.Distance(vertices[2], p));

        var R = Math.Min((colors[0].R * distancesVector.X + colors[1].R * distancesVector.Y + colors[2].R * distancesVector.Z) /
                (distancesVector.X + distancesVector.Y + distancesVector.Z), 255);
        var G = Math.Min((colors[0].G * distancesVector.X + colors[1].G * distancesVector.Y + colors[2].G * distancesVector.Z) /
                (distancesVector.X + distancesVector.Y + distancesVector.Z), 255);
        var B = Math.Min((colors[0].B * distancesVector.X + colors[1].B * distancesVector.Y + colors[2].B * distancesVector.Z) /
                (distancesVector.X + distancesVector.Y + distancesVector.Z), 255);

        return Color.FromArgb((int)R, (int)G, (int)B);
    }

    public Color CalculateColor(Vector3 N, Vector3 L, Color Io, Color Il, double kd, double ks, double m)
    {
        
        double cosNL = N.X * L.X + N.Y * L.Y + N.Z * L.Z;
        cosNL = cosNL < 0 ? 0 : cosNL;

        var R = 2*((float)cosNL)*N - L;
        double cosVR = 1 * R.Z;
        cosVR = cosVR < 0 ? 0 : cosVR;

        var Ir = Io.R * Il.R * (kd * cosNL + ks * Math.Pow(cosVR, m));
        Ir = Ir > 255 ? 255 : Ir;
        Ir = Ir < 0 ? 0 : Ir;
        var Ig = Io.G * Il.G * (kd * cosNL + ks * Math.Pow(cosVR, m));
        Ig = Ig > 255 ? 255 : Ig;
        Ig = Ig < 0 ? 0 : Ig;

        var Ib = Io.B * Il.B * (kd * cosNL + ks * Math.Pow(cosVR, m));
        Ib = Ib > 255 ? 255 : Ib;
        Ib = Ib < 0 ? 0 : Ib;

        return Color.FromArgb((int)Ir, (int)Ig, (int)Ib);
    }
}