using System.Numerics;
using WinFormsApp.GeometryComponents;

namespace WinFormsApp.GraphicTools;

public class Painter
{
    private int _colorCount = 0;
    public Painter()
    {
    }
    
    public void FillPolygon(Face face, Bitmap textureBitmap, DirectBitmap drawingBitmap, Illumination illumination, SurfaceProperties surface, NormalMap normalMap)
    {
        ScanLine scanLine = new ScanLine(face.Edges);
        
        var vertices = face.Vertices;

        ColorGenerator colorGenerator = new ColorGenerator(illumination, textureBitmap, vertices, surface, normalMap);

        while (!scanLine.IsEnd)
        {
            scanLine.UpdateAet();

            var intersectionPoints = scanLine.IntersectionPoints.ToList();
            if (intersectionPoints.Count() > 1)
            {
                for (int x = intersectionPoints[0]; x <= intersectionPoints[1]; x++)
                {
                    drawingBitmap.SetPixel(x, scanLine.CurrentY, colorGenerator.GetColorInPoint(x, scanLine.CurrentY));
                }

                _colorCount++;
            }
        }
    }
}