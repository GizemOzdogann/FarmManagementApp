using FarmManagementApp.Data;
using FarmManagementApp.Forms;

namespace FarmManagementApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            //Application.Run(new AddNewAnimal());

        }
    }
}

// dependency injection in form applications