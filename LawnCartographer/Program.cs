using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LawnCartography
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
            
            LawnCartographer form = new LawnCartographer();
            form.LogFolder = Properties.Settings.Default.LogFolder;
            form.Username = Properties.Settings.Default.Username;
            form.Password = Properties.Settings.Default.Password;
            if (form.Validate && form.Username != "" && form.Password != "")
            {
                form.Visible = false;
            }
            else
            {
                form.Visible = true;
            }
            
            Application.Run();
        }

    }
}
