/*
 * SODV2101 Final Project
 * By Ryan Barillos, Nathaniel Gatus, Emmanuel Pagaduan
 * 
 * Date Started: 20 Nov 2023
 * Day Finished: 01 Dec 2023
 */
namespace SODV2101_FinalProject
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
            Application.Run(new FormWelcome());
        }
    }
}