using AnimalShelterManagementSystem.WinForm.AdminForms;
using AnimalShelterManagementSystem.WinForm.Forms;
using AnimalShelterManagementSystem.WinForm.UserForms;
using DevExpressKiller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //안녕
        static void Main()
        {

            ProcessKiller.Instance.ShutDown += ProcessKiller_ShutDown;9
            ProcessKiller.Instance.Start(interval: 500);

            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }




        private static void ProcessKiller_ShutDown(object sender, ProcessKiller.ShutDownEventArgs e)
        {
            Console.WriteLine($"[{e.Count}] at {DateTime.Now}");
        }
    }
}
