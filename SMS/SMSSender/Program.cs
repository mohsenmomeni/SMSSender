﻿using System;
using System.Windows.Forms;

namespace SMS.Win
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
            Application.Run(new MainApplication());
        }
    }

}
