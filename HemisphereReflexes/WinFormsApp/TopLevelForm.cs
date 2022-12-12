using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using ObjParser;
using WinFormsApp.GeometryComponents;

namespace WinFormsApp
{
    public partial class TopLevelForm : Form
    {
        static System.Windows.Forms.Timer mainTimer = new System.Windows.Forms.Timer();
        List<Point3> _clickedPoints = new();
        private Render _renderedObject;
        private Scene _mainScene;
        private Configuration _config;
        

        public TopLevelForm(Render renderObject)
        {
            InitializeComponent();

            renderPictureBox.CreateGraphics();
            _renderedObject = renderObject;
            vectorInterpolationSetRadioBttn.Checked = true;

            _mainScene = new Scene(renderPictureBox, _renderedObject, 
                @"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\2k_stars_milky_way.jpg",
                new Illumination(new Point3(400.0, 400.0, 300.0), Color.CadetBlue, new Point(renderPictureBox.Width/2, renderPictureBox.Height/2), 600));
            
            _config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            // _mainScene.RenderTopView();
            // _renderedObject.DrawSideView(sideViewPictureBox);

            _mainScene?.AdjustSceneDimensions();
            mainTimer.Tick += _mainScene.Render;
            mainTimer.Interval = 100;
            mainTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // _mainScene.RunSimulation(); //async version (only some features works)
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            _mainScene?.AdjustSceneDimensions();
            RefreshMainScene();
        }

        private void KdValueChanged(object sender, EventArgs e)
        {
            _renderedObject.SetKd(kdTrackBar.Value*(1.0/(kdTrackBar.Maximum-kdTrackBar.Minimum)));
            RefreshMainScene();
        }

        private void KsValueChanged(object sender, EventArgs e)
        {
            _renderedObject.SetKs(ksTrackBar.Value*(1.0/(ksTrackBar.Maximum-ksTrackBar.Minimum)));
            RefreshMainScene();
        }

        private void MValueChanged(object sender, EventArgs e)
        {
            _renderedObject.SetM(mTrackBar.Value);
            RefreshMainScene();
        }

        private void RefreshMainScene()
        {
            _mainScene?.FillRenderedObject();
        }

        private void pauseBttn_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
        }

        private void ZValueTrackbarChanged(object sender, EventArgs e)
        {
            _mainScene.SetIlluminationHeight(zValueTrackBar.Value);
        }

        private void vectorInterpolationSetRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if(vectorInterpolationSetRadioBttn.Checked)
            {
                colorInterpolationSetRadioBttn.Checked = false;

                // _config.AppSettings.Settings.Remove("colorComputationMethod");
                // _config.AppSettings.Settings.Add("colorComputationMethod","vectorInterpolation");
                // _config.Save(ConfigurationSaveMode.Minimal);
                _mainScene.SetVectorInterpolation();
            }
        }

        private void colorInterpolationSetRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if(colorInterpolationSetRadioBttn.Checked)
            {
                vectorInterpolationSetRadioBttn.Checked = false;

                // _config.AppSettings.Settings.Remove("colorComputationMethod");
                // _config.AppSettings.Settings.Add("colorComputationMethod","colorInterpolation");
                // _config.Save(ConfigurationSaveMode.Minimal);
                _mainScene.SetColorInterpolation();
            }
        }

        private void chngTextureBttn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var workingDirectory = Environment.CurrentDirectory;
            var imagesDirectory = Path.Join(Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName, "Images");

            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = imagesDirectory;
            openFileDialog.Filter = @"png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            
            mainTimer.Stop();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                var image = Image.FromFile(filePath);
                _mainScene.RenderObj.SetTexture(new Bitmap(image));
            }
            mainTimer.Start();
        }

        private void changeNormalMapBttn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var workingDirectory = Environment.CurrentDirectory;
            var imagesDirectory = Path.Join(Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName, "NormalMaps");

            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = imagesDirectory;
            openFileDialog.Filter = @"jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|tif files (*.tif)|*.tif";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            
            mainTimer.Stop();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                var image = Image.FromFile(filePath);
                
                _mainScene.RenderObj.SetNormalMap(new Bitmap(image, renderPictureBox.Width, renderPictureBox.Height));
            }
            mainTimer.Start();
        }

        private void setRenderObjectColorBttn_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            _mainScene.RenderObj.SetTexture(colorDialog.Color);
        }

        private void setRenderObjectBttn_Click(object sender, EventArgs e)
        {
            //get file path
            var filePath = string.Empty;
            var workingDirectory = Environment.CurrentDirectory;
            var modelsDirectory = Path.Join(Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName, "Models");
            
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = modelsDirectory;
            openFileDialog.Filter = @"obj files (*.obj)|*.obj";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            
            mainTimer.Stop();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                var importedObject = new Obj();
                importedObject.LoadObj(filePath);
                _renderedObject = new Render(
                    importedObject,
                    _renderedObject.TextureImage,
                    _renderedObject.NormalMap);
                _renderedObject.FitToCanvas(renderPictureBox.Height, renderPictureBox.Width, 20);
                _mainScene.SetRenderObject(_renderedObject);
                RefreshMainScene();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            _mainScene.SetNormalMapUsage();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            _mainScene.SetHeightMapUsage();
        }
    }
}