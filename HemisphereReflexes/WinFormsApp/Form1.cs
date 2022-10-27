namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        List<Point3D> _clickedPoints = new List<Point3D>();

        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            Point3D p = new Point3D(21, 244, 120);

            debugTextBox.Clear();
            debugTextBox.AppendText(p.Coordinates.ToString());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //var clicked_point2D = 
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