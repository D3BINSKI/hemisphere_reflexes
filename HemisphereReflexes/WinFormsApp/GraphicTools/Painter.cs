using System.Configuration;
using System.Numerics;
using WinFormsApp.GeometryComponents;

namespace WinFormsApp.GraphicTools;

public class Painter
{
    private int _colorCount = 0;
    private ScanLine _scanLine;
    
    public Painter()
    {
        _scanLine = new ScanLine();
    }
    
    public void FillPolygon(Face face, Bitmap textureBitmap, DirectBitmap drawingBitmap, Illumination illumination, SurfaceProperties surface, NormalMap? normalMap, HeightMap? heightMap, bool isVectorInterpolation, bool isHeightMapUsed)
    {
        _scanLine.Initialize(face.Edges);
        
        var vertices = face.Vertices;

        ColorGenerator colorGenerator = new ColorGenerator(illumination, textureBitmap, vertices, surface, normalMap, heightMap, isVectorInterpolation, isHeightMapUsed);

        while (!_scanLine.IsEnd)
        {
            _scanLine.UpdateAet();

            var intersectionPoints = _scanLine.IntersectionPoints;
            if (intersectionPoints.Count() > 1)
            {
                for (int x = intersectionPoints.First(); x <= intersectionPoints.Last(); x++)
                {
                    drawingBitmap.SetPixel(x, _scanLine.CurrentY, colorGenerator.GetColorInPoint(x, _scanLine.CurrentY));
                }

                _colorCount++;
            }
        }
    }
}