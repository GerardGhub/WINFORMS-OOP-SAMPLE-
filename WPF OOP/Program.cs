using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_OOP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {


                if (Environment.OSVersion.Version.Major == 6)
                    //SetProcessDPIAware();



                    System.Windows.Forms.Application.EnableVisualStyles();
               System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);


                FrmLoginForm login = new FrmLoginForm();
                login.Show();

                System.Windows.Forms.Application.Run();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
