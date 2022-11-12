using System.Diagnostics.CodeAnalysis;
using WinFormsApp.Drawing;

namespace WinFormsApp;

using GraphicComponents;

public class Scene
{
    private Render _renderObj;
    private Illumination _sceneIllumination;
    private PictureBox _scenePictureBox;
    private DirectBitmap _bitmap;
    private Drawing.Drawing _drawing;
    private Image _choosenSceneImage;

    public DirectBitmap Bitmap => _bitmap;
    
    public Scene(PictureBox pictureBox, Render renderObj, string backgroundFile, Illumination illumination)
    {
        _renderObj = renderObj;
        _scenePictureBox = pictureBox;
        _choosenSceneImage = Image.FromFile(backgroundFile);
        _bitmap = new DirectBitmap(new Bitmap(_choosenSceneImage, pictureBox.Width, pictureBox.Height));
        _sceneIllumination = illumination;
        _scenePictureBox.Image = _bitmap.Bitmap;
        _drawing = new Drawing.Drawing();
    }

    [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: System.Int32[]")]
    public void RenderTopView()
    {
        _renderObj.DrawTopView(this);
        _scenePictureBox.Invalidate(new Rectangle(0,0,_bitmap.Width, Bitmap.Height));
        _scenePictureBox.Update();
    }

    public void FillRenderedObject()
    {
        _renderObj.FillFaces(_drawing, _bitmap.Bitmap, _sceneIllumination);

        using var graphics = Graphics.FromImage(this._bitmap.Bitmap);
        graphics.DrawLine(Pens.Black,0,0,100,100);
        _scenePictureBox.Invalidate(new Rectangle(0,0,_bitmap.Width, Bitmap.Height));
        _scenePictureBox.Update();
    }

    public void AdjustSceneDimensions()
    {
        UpdateBitmap();
        AdjustRenderSize();
    }

    [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: System.Int32[]")]
    public void UpdateBitmap()
    {
        _bitmap = new DirectBitmap(new Bitmap(_choosenSceneImage, _scenePictureBox.Width, _scenePictureBox.Height));
        _scenePictureBox.Image = _bitmap.Bitmap;
    }
    
    public void AdjustRenderSize()
    {
        _renderObj.FitToCanvas(_bitmap.Height, _bitmap.Width, 20);
    }
}