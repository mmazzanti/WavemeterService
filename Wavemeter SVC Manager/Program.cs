﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using System.Threading;


namespace Wavemeter_SVC_Manager
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
            Form1 FormAPP = new Form1();
            Application.Run(FormAPP);
            FormAPP.runt=false;
        }
        public enum SimpleServiceCustomCommands { StopWorker = 128, RestartWorker, CheckWorker };
    }

}