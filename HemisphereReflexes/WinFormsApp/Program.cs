using ObjParser;
using WinFormsApp.GeometryComponents;

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
            Render render = new Render(importedObject, Image.FromFile(@"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\Color-Green.jpg"));
            Application.Run(new TopLevelForm(render));
        }
    }
}