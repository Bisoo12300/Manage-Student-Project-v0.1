using QLSV;
using System.Windows.Forms;
using System;
using QLSV.NewFolder1;

namespace QLSV
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());

            
        }
        
    }
}