﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Dennis Kanzira
 * StudentID:300914940
 * Date:Auguest 1,2017
 * Description: Demo Application to showcase windows form and UI application
 * version 0.1: project was created.
*/
namespace Comp123_lesson123_2b
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
            Application.Run(new DemoForm());
        }
    }
}
