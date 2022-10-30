using ObjParser;

namespace WinFormsApp
{
    public partial class TopLevelForm : Form
    {
        List<Point3D> _clickedPoints = new List<Point3D>();
        private Render _renderedObject;
        IEnumerable<Edge> _edgesToDraw;
        private Bitmap _renderViewBitmap;
        private Graphics _graphics;

        public TopLevelForm(Render renderObject)
        {
            InitializeComponent();
            _graphics = renderPictureBox.CreateGraphics();
            _renderedObject = renderObject;

            _renderedObject.DrawTopView(renderPictureBox);
            _renderedObject.DrawSideView(sideViewPictureBox);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            _renderedObject.DrawTopView(renderPictureBox);
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

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            _renderedObject?.DrawTopView(renderPictureBox);
        }
    }
}