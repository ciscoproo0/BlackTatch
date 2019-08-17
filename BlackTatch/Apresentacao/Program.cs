using System;
using System.Threading;
using System.Windows.Forms;

namespace Apresentacao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen frmSplash = new SplashScreen();
            frmSplash.Show();
            Application.DoEvents();

            Thread.Sleep(2500);
            frmSplash.Dispose();
            Application.Run(new frmBemVindo());
           /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());*/
        }
    }
}
