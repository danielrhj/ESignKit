using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;

namespace CostErrDeal.KFErr
{
    public partial class frmEalFileFlag : Form
    {
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";

        public frmEalFileFlag()
        {
            InitializeComponent();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            string sEalNo = txtEalNo.Text.Trim();
            if (sEalNo == "")
            {
                MessageBox.Show("提示,请输入你要更新的预结报单号！");
                txtEalNo.Focus();
                return;
            }
            MssqlDAL dal = new MssqlDAL(CostDB, "update eal_file set eal04='1' where eal01='" + sEalNo + "'");
            dal.UpdateSingle();
            MessageBox.Show("已成功更新状态!");
        }
    }
}
