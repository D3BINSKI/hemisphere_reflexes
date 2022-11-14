using System.Configuration;
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
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings.Remove("colorComputationMethod");
            config.AppSettings.Settings.Add("colorComputationMethod","vectorInterpolation");
            config.Save(ConfigurationSaveMode.Minimal);
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var importedObject = new Obj();
            importedObject.LoadObj(@"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\data\icosphere-3.obj");
            Render render = new Render(
                importedObject, 
                Image.FromFile(@"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\2k_earth_daymap.jpg"),
                new NormalMap(Image.FromFile(@"D:\Software\Projects\Computer Graphics\hemisphere_reflexes\HemisphereReflexes\WinFormsApp\Images\2k_earth_normal_map.tif"), new Size(500, 500)));
            Application.Run(new TopLevelForm(render));
        }
    }
}