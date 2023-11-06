//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

namespace apRedeDeTrens
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
            Application.Run(new FrmMapeamentoCidades());
        }
    }
}