namespace WinFormsApp;

public class Face
{
    private List<Vertex> _vertices;
    private readonly List<Edge> _edges;
    
    public List<Vertex> Vertices => _vertices;
    public List<Edge> Edges => _edges;

    public Face(List<Vertex> vertices)
    {
        _vertices = vertices;
        _edges = new List<Edge>();
        _edges?.Add(new Edge(_vertices[0], _vertices[1]));
        _edges?.Add(new Edge(_vertices[1], _vertices[2]));
        _edges?.Add(new Edge(_vertices[2], _vertices[0]));
    }

    public void Scale(float scaleX, float scaleY, float scaleZ)
    {
        foreach (var vertex in _vertices)
        {
            vertex.Scale(scaleX, scaleX, scaleZ);
        }
    }
    
}