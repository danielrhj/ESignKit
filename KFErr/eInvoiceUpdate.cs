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
    public partial class eInvoiceUpdate : Form
    {
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";

        public eInvoiceUpdate()
        {
            InitializeComponent();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            string sPreviewNo = txtPreviewNo.Text.Trim();
            if (sPreviewNo == "")
            {
                MessageBox.Show("提示,请输入你要更新的单号！");
                txtPreviewNo.Focus();
                return;
            }
            MssqlDAL dal = new MssqlDAL(CostDB, "update GC_eInvoice_Info set TXTFlag='N' where PreviewNo='" + txtPreviewNo.Text.Trim() + "'");
            dal.UpdateSingle();
            MessageBox.Show("已成功更新状态!");
        }
    }
}
