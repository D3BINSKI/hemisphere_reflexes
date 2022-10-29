using ObjParser;

namespace WinFormsApp;

public class Render
{
    public List<Face> Faces { get; }
    public List<Vertex> Vertices { get; }

    private double _xSpan;
    private double _ySpan;

    private (double, double) center;

    public Render(Obj renderedObject)
    {
        Vertices = new List<Vertex>();
        Faces = new List<Face>();
        
        foreach (var vertex in renderedObject.VertexList)
        {
            Vertices.Add(new Vertex((float)vertex.X, (float)vertex.Y, (float)vertex.Z, vertex.Index));
        }
        
        foreach (var face in renderedObject.FaceList)
        {
            Faces.Add(new Face(Vertices.FindAll(v => face.VertexIndexList.Contains(v.Id))));
        }

        center = ((renderedObject.Size.XMax + renderedObject.Size.XMin) / 2,
            (renderedObject.Size.YMax - renderedObject.Size.YMin) / 2);
        
        _xSpan = 2 * Math.Max(
            Math.Abs(renderedObject.Size.XMax - center.Item1),
            Math.Abs(renderedObject.Size.XMin - center.Item1));
        
        _ySpan = 2 * Math.Max(
            Math.Abs(renderedObject.Size.YMax - center.Item2),
            Math.Abs(renderedObject.Size.YMin - center.Item2));
    }

    public void Scale(float height, float width)
    {
        var kX = width / _xSpan;
        var kY = height / _ySpan;
        _xSpan *= kX;
        _ySpan *= kY;

        foreach (var vertex in Vertices)
        {
            vertex.Scale((float)kX, (float)kY, 1);
        }
    }

    public void MoveCenter(float x, float y)
    {
        var deltaX = x - center.Item1;
        var deltaY = y - center.Item2;

        foreach (var vertex in Vertices)
        {
            vertex.Move((float)deltaX, (float)deltaY);
        }

        center = (x, y);
    }
}