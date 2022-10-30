using ObjParser;

namespace WinFormsApp;

public class Render
{
    public List<Face> Faces { get; }
    public List<Vertex> Vertices { get; }

    public IEnumerable<Edge> Edges { get; }

    private double _xSpan;
    private double _ySpan;
    private double _zSpan;

    private (double x, double y, double z) center;

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
        
        Edges = Faces.SelectMany(face => face.Edges).Distinct();


        center = ((renderedObject.Size.XMax + renderedObject.Size.XMin) / 2,
            (renderedObject.Size.YMax - renderedObject.Size.YMin) / 2,
            renderedObject.Size.ZMin);
        
        _xSpan = 2 * Math.Max(
            Math.Abs(renderedObject.Size.XMax - center.x),
            Math.Abs(renderedObject.Size.XMin - center.x));
        
        _ySpan = 2 * Math.Max(
            Math.Abs(renderedObject.Size.YMax - center.y),
            Math.Abs(renderedObject.Size.YMin - center.y));
        
        _zSpan = Math.Abs(renderedObject.Size.ZMax - renderedObject.Size.ZMin);
    }

    public void ScaleXY(float height, float width)
    {
        var kX = width / _xSpan;
        var kY = height / _ySpan;
        _xSpan *= kX;
        _ySpan *= kY;
        _zSpan *= 1;

        foreach (var vertex in Vertices)
        {
            vertex.Scale((float)kX, (float)kY, 1);
        }
    }
    
    public void ScaleXZ(float height, float width)
    {
        var kX = width / _xSpan;
        var kY = 1;
        var kZ = height / _zSpan;
        _xSpan *= kX;
        _ySpan *= kY;
        _zSpan *= kZ;

        foreach (var vertex in Vertices)
        {
            vertex.Scale((float)kX, 1, (float)kZ);
        }
    }

    public void MoveCenter(float x, float y, float z)
    {
        var deltaX = x - center.x;
        var deltaY = y - center.y;
        var deltaZ = z - center.z;

        foreach (var vertex in Vertices)
        {
            vertex.Move((float)deltaX, (float)deltaY, (float)deltaZ);
        }

        center = (x, y, z);
    }

    public void DrawTopView(PictureBox pictureBox)
    {
        var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        using var graphics = Graphics.FromImage(bitmap);
        
        MoveCenter(0, 0, 0);
        ScaleXY(2*bitmap.Height - 50, bitmap.Width - 50);
        MoveCenter(bitmap.Width/2, bitmap.Height - 10, 1);

        
        foreach (var edge in Edges)
        {
            edge.DrawXY(graphics);
        }

        pictureBox.Image = bitmap;
    }
    
    public void DrawSideView(PictureBox pictureBox)
    {

        var bitmap = pictureBox.Image ?? new Bitmap(pictureBox.Width, pictureBox.Height);
        using var graphics = Graphics.FromImage(bitmap);
        
        MoveCenter(0, 0, 0);
        ScaleXZ(bitmap.Height/2, bitmap.Width);
        MoveCenter(bitmap.Width/2, bitmap.Height - 10, 1);

        
        foreach (var edge in Edges)
        {
            edge.DrawXZ(graphics);
        }
        bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
        pictureBox.Image = bitmap;
    }
}