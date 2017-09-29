using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using OfficeOpenXml;
using System.IO;

namespace CostErrDeal.Esign
{
    public partial class SendEalAccount : Form
    {
        public SendEalAccount()
        {
            InitializeComponent();
        }

        private void btnSendTo_Click(object sender, EventArgs e)
        {
            lblMsg1.Text = "";
            if (txtEalNo.Text.Trim() == "")
            {
                MessageBox.Show("提示：預結報號碼不能為空!");
                this.txtEalNo.Focus();
                return;
            }

            AccountService.AccountService AccountService = new CostErrDeal.AccountService.AccountService();
            try
            {
                lblMsg1.Text = "[拋轉預結報]:  " + AccountService.SendMessageFromLogistic_ALL(txtEalNo.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMsg1.Text = "[拋轉預結報]:  " + ex.Message.ToString();
            }
        }

        private void btnDelEal_Click(object sender, EventArgs e)
        {
            if (txtEalNo.Text.Trim() == "")
            {
                MessageBox.Show("提示：預結報號碼不能為空!");
                this.txtEalNo.Focus();
                return;
            }

            AccountService.AccountService AccountService = new CostErrDeal.AccountService.AccountService();
            lblMsg1.Text = "[刪除預結報]:  " + AccountService.DelMessageFromFI_ALL(txtEalNo.Text.Trim());
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            try
            {
                IBM.Data.Informix.IfxConnection ifxcnn = new IBM.Data.Informix.IfxConnection();
                ifxcnn.ConnectionString = "Server=on_tcp506;DataBase=yzhzhn;User Id=ODBCCFA2;password=ODBC0001;Host=10.157.37.70;Protocol=onsoctcp;service=9506;DB_LOCALE=zh_TW.57352;CLIENT_LOCALE=zh_TW.57352";
                ifxcnn.ClientLocale = "zh_TW.57352";
                ifxcnn.DatabaseLocale = "zh_TW.57352";

                ifxcnn.Open();
                lblMsg1.Text = "OK";
            }
            catch (Exception ex)
            {
                lblMsg1.Text = ex.Message;
            }

        }

        private void btnEPTest_Click(object sender, EventArgs e)
        {
            //using (OfficeOpenXml.ExcelPackage ep = new OfficeOpenXml.ExcelPackage(new FileInfo(@"D:\supplierTest.xlsx")))
            //{
                
            //}
        }
    }
}
