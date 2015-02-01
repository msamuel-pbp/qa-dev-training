using System;
using System.Windows.Forms;

namespace Chapter18 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmFileCopier());
            //Application.Run(new Exercise1());
            //Application.Run(new Exercise2());
            Application.Run(new Exercise3());
        }
    }
}
