using ObjParser;

namespace WinFormsApp
{
    public partial class TopLevelForm : Form
    {
        List<Point3D> _clickedPoints = new List<Point3D>();
        private Render _renderedObject;
        IEnumerable<(Vertex, Vertex)> _edgesToDraw;

        public TopLevelForm(Render renderObject)
        {
            InitializeComponent();
            
            _renderedObject = renderObject;

            _edgesToDraw = _renderedObject.Faces.SelectMany(face => face.Edges).Distinct();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            _renderedObject.MoveCenter(0, 0);
            _renderedObject.Scale(2*pictureBox1.Height - 50, pictureBox1.Width - 50);
            _renderedObject.MoveCenter(pictureBox1.Width/2, 2*pictureBox1.Height/2 - 10);
            
            var g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            foreach (var edge in _edgesToDraw)
            {
                g.DrawLine(Pens.Black, new Point((int)edge.Item1.X, (int)edge.Item1.Y), 
                    new Point((int)edge.Item2.X, (int)edge.Item2.Y));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            
            var clickedPoint = new Point3D(mouseEventArgs.X, mouseEventArgs.Y, 0);
            _clickedPoints.Add(clickedPoint);

            if (_clickedPoints.Count == 2)
            {
                debugTextBox.Clear();
                debugTextBox.AppendText((_clickedPoints[1] - _clickedPoints[0]).ToString()!);
                _clickedPoints.Clear();
            }
        }
    }
}