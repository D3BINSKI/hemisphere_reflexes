using ObjParser;
using WinFormsApp.GeometryComponents;
using WinFormsApp.GraphicTools;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var importedObject = new Obj();
            importedObject.LoadObj(@"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\data\icosphere-3.obj");
            Render render = new Render(
                importedObject, 
                Image.FromFile(@"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\booster-rocket-raptor-engines.jpg"),
                new NormalMap(Image.FromFile(@"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\NormalMap_raptors.png"), new Size(500, 500)));
            Application.Run(new TopLevelForm(render));
        }
    }
}