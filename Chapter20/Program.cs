﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter20 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        public static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var foo = new Exercise3();
            foo.Run();
        }
    }
}
