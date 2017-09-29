using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CostErrDeal.KFErr
{
    public partial class frmKFPicture : Form
    {
        public frmKFPicture()
        {
            string strpath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            strpath = strpath + @"物流費用發票電子簽核系統文檔.doc";
            System.Diagnostics.Process.Start("explorer.exe", strpath);

        }
    }
}
