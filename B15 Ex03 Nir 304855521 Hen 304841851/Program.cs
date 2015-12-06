using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
