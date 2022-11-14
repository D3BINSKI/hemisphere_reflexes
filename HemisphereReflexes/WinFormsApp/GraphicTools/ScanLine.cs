using WinFormsApp.GeometryComponents;

namespace WinFormsApp.GraphicTools;

public class ScanLine
{
    private List<AETPointer>[] _et;
    private List<AETPointer> _aet;
    private int _currentY;
    private int _edgesCount;

    public int CurrentY => _currentY;

    public ScanLine()
    {
        _et = new List<AETPointer>[1500];
        _aet = new List<AETPointer>();
        _edgesCount = 0;
    }

    public void Initialize(List<Edge> edges)
    {
        var globalYMin = 1500;
        _edgesCount = edges.Count;
        
        foreach (var edge in edges)
        {
            if (Math.Min(edge.V1.Y, edge.V2.Y) < globalYMin) globalYMin = (int)Math.Min(edge.V1.Y, edge.V2.Y);
        }
        foreach (var edge in edges)
        {
            var yMin = edge.V1.Y < edge.V2.Y ? (int)edge.V1.Y : (int)edge.V2.Y;
            if (edge.Slope == 0)
            {
                _edgesCount--;
                continue;
            }
            _et[yMin] ??= new List<AETPointer>();
            _et[yMin].Add(new AETPointer((int)Math.Max(edge.V1.Y, edge.V2.Y),
                edge.V1.Y < edge.V2.Y ? edge.V1.X : edge.V2.X, edge.Slope));
            _et[yMin].Sort();
        }

        _currentY = globalYMin;
    }
    

    public IEnumerable<int> IntersectionPoints => _aet.Select(pointer => pointer.X);

    public bool IsEnd => !(_aet.Any() || _edgesCount != 0);
    
    public void UpdateAet()
    {
        if (_et[_currentY] is not null)
        {
            foreach (var pointer in _et[_currentY])
            {
                _aet.Add(pointer);
                _edgesCount--;
            }
        }
        _et[_currentY]?.Clear();


        _aet.RemoveAll(pointer => pointer.YMax <= _currentY);
        
        _currentY += 1;
        _aet.ForEach(pointer => pointer.UpdateX());
        _aet.Sort();
    }
}