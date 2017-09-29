using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Foxconn.GLISPLL;
using DIYGENS.COM.DBLL.Mssql;

namespace CostErrDeal
{
    public partial class frmLogin : Form
    {
        MssqlFields fields = new MssqlFields();
        DataTable dt = new DataTable();
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";

        private bool isLogin = false;
        public string getIPPwd = "";
        private string usercode="";

        public bool ISLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }

        public string UserCode
        {
            get { return usercode; }
            set { usercode = value; }
        }

        public frmLogin()
        {
            InitializeComponent();
            string IPV4 = Command.GetSelfIpv4List().Replace(";", "");
            //IPV4 = "10.132.192.207";
            try
            {
                fields.Clear();
                fields.Add("ActionType", "GetUseRole");
                fields.Add("Type", "getUserForIPV4");
                fields.Add("OldCode", IPV4);

                MssqlDAL dal = new MssqlDAL(CostDB, "WF_EsignInvoice_CodeUpdate", fields);
                dt = dal.GetList().Tables[0];
                if (dt.Rows.Count > 0)
                {
                    txtUserCode.Text = dt.Rows[0][0].ToString(); this.UserCode = txtUserCode.Text;
                    txtPassword.Text = dt.Rows[0][1].ToString();
                    getIPPwd = txtPassword.Text.Trim();
                }
            }
            catch(Exception ex)
            {
                string AA = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl0.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;

            string pwdMD5 = getIPPwd == "" ? MD5.md5(txtPassword.Text) : getIPPwd;
            fields.Clear();
            fields.Add("ActionType", "GetUseRole");
            fields.Add("Type", "getUser");
            fields.Add("OldCode", txtUserCode.Text.Trim());
            fields.Add("OrderNo", pwdMD5);
            MssqlDAL dal = new MssqlDAL(CostDB, "WF_EsignInvoice_CodeUpdate", fields);
            try
            {
                DataTable dt = dal.GetList().Tables[0];
                if (dt.Rows.Count > 0)
                {
                    usercode = txtUserCode.Text.Trim();
                    isLogin = true;
                    this.Close();
                }
                else
                {
                    lbl0.Visible = true;
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl3.Visible = true;
                }
            }
            catch
            {
                lbl0.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
            }
            dal = null;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            getIPPwd = "";
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(null, null);
            }
        }

    }
}
