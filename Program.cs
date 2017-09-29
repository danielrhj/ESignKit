using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CostErrDeal
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmLogin frmlogin = new frmLogin();
            frmlogin.ShowDialog();
            
            if (frmlogin.ISLogin == true)
            {
                Application.Run(new MDIMain(frmlogin.UserCode));
            }
        }
    }
}
