using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTroopers;

namespace WindowsFormsApp
{
    static class FactoryTesting
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EjercitoImperial ejercito = new EjercitoImperial(50);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPpal(ejercito));
        }
    }
}
