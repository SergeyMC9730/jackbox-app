using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace jackboxapp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Loading...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 frm = new Form1();
            //frm.setTrue();
            Application.Run(new Form1());
        }
    }
}
