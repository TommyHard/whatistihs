﻿using ITsecutiryConferences.Forms;
using System;
using System.Windows.Forms;

namespace ITsecutiryConferences
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
