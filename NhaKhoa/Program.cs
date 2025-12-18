using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaKhoa
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

            bool shouldRestart;
            do
            {
                shouldRestart = false;
                var login = new Login();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    var main = new frmMain(login.LoggedInRole);
                    main.FormClosed += (s, args) =>
                    {
                        if (main.DialogResult == DialogResult.Abort)
                            shouldRestart = true;
                    };
                    Application.Run(main);
                }
                else
                {
                    break; // Thoát nếu không đăng nhập
                }
            } while (shouldRestart);
        }
    }
}
