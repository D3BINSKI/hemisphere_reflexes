using System.Diagnostics.CodeAnalysis;
using ObjParser;
using WinFormsApp.GeometryComponents;

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
                @"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\booster-rocket-raptor-engines.jpg",
                new Illumination(new Point3(400.0, 400.0, 800.0), Color.CadetBlue));
            
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
            _renderedObject.SetKd(kdTrackBar.Value*(1.0/(kdTrackBar.Maximum-kdTrackBar.Minimum)));
            RefreshMainScene();
            LogTrackBarsValueChange();
        }

        private void KsValueChanged(object sender, EventArgs e)
        {
            _renderedObject.SetKs(ksTrackBar.Value*(1.0/(ksTrackBar.Maximum-ksTrackBar.Minimum)));
            RefreshMainScene();
            LogTrackBarsValueChange();
        }

        private void MValueChanged(object sender, EventArgs e)
        {
            _renderedObject.SetM(mTrackBar.Value);
            RefreshMainScene();
            LogTrackBarsValueChange();
        }

        private void LogTrackBarsValueChange()
        {
            debugTextBox.Clear();
            debugTextBox.AppendText($"kd Value = {_renderedObject.Surface.Kd}\n");
            debugTextBox.AppendText($"ks Value = {_renderedObject.Surface.Ks}\n");
            debugTextBox.AppendText($"m Value = {_renderedObject.Surface.M}\n");
        }

        private void RefreshMainScene()
        {
            _mainScene.FillRenderedObject();
        }
    }
}