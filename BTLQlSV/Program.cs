﻿using BTLQlSV.Quản_trị_viên;
using BTLQlSV.Quản_trị_viên.Quản_lý_sinh_viên;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQlSV
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm()//set form khởi đầu là formDSSV
            {
            });
        }
    }
}
