using System;
using System.Windows.Forms;
using Flower_Management_System.Login;
using Flower_Management_System.Cart_Management;
using Flower_Management_System.Splash_Screen;
using Flower_Management_System.Flower_Management;

namespace Flower_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form(""));
        }
    }
}
