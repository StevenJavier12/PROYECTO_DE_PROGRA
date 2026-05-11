namespace PROSERA.WinFormsUI
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
<<<<<<< HEAD
            Application.Run(new InicioDeSesion());
=======
            Application.Run(new ControlAdmin());
>>>>>>> 6ce581e90b98e4e95615467f4721850797dbd84d
        }
    }
}