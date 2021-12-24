﻿using POSK3.Ekrany;
using System;
using System.Windows.Forms;

namespace POSK3
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogowanieForm());
        }
    }
}
