using System.Diagnostics.CodeAnalysis;
using ObjParser;
using WinFormsApp.Drawing;
using WinFormsApp.GraphicComponents;

namespace WinFormsApp
{
    public partial class TopLevelForm : Form
    {
        List<Point3> _clickedPoints = new List<Point3>();
        private Render _renderedObject;
        private Scene _mainScene;
        

        public TopLevelForm(Render renderObject)
        {
            InitializeComponent();

            renderPictureBox.CreateGraphics();
            _renderedObject = renderObject;

            _mainScene = new Scene(renderPictureBox, _renderedObject, 
                @"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\pexels-photo-2178028.jpeg",
                new Illumination(new Point3(300.0, 300.0, 800.0), Color.CadetBlue));
            
            _mainScene.RenderTopView();
            _renderedObject.DrawSideView(sideViewPictureBox);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            
            var clickedPoint = new Point3(mouseEventArgs.X, mouseEventArgs.Y, 0);
            _clickedPoints.Add(clickedPoint);

            if (_clickedPoints.Count == 2)
            {
                debugTextBox.Clear();
                debugTextBox.AppendText((_clickedPoints[1] - _clickedPoints[0]).ToString()!);
                _clickedPoints.Clear();
            }
            
            _mainScene.FillRenderedObject();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            _mainScene?.AdjustSceneDimensions();
            // _mainScene?.RenderTopView();
            _mainScene?.FillRenderedObject();
        }

        private void KdValueChanged(object sender, EventArgs e)
        {
            _renderedObject.Kd = kdTrackBar.Value*(1.0/(kdTrackBar.Maximum-kdTrackBar.Minimum));
            LogTrackBarsValueChange();
        }

        private void KsValueChanged(object sender, EventArgs e)
        {
            _renderedObject.Ks = ksTrackBar.Value*(1.0/(kdTrackBar.Maximum-kdTrackBar.Minimum));
            LogTrackBarsValueChange();
        }

        private void MValueChanged(object sender, EventArgs e)
        {
            _renderedObject.M = mTrackBar.Value;
            LogTrackBarsValueChange();
        }

        private void LogTrackBarsValueChange()
        {
            debugTextBox.Clear();
            debugTextBox.AppendText($"kd Value = {_renderedObject.Kd}\n");
            debugTextBox.AppendText($"ks Value = {_renderedObject.Ks}\n");
            debugTextBox.AppendText($"m Value = {_renderedObject.M}\n");
        }
    }
}