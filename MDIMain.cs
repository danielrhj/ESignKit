using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;

namespace CostErrDeal
{
    public partial class MDIMain : Form
    {
        MssqlFields fields = new MssqlFields();

        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";
        private int childFormNumber = 0;
        public MDIMain(string strUserCode)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            fields.Clear();
            fields.Add("ActionType", "GetUseRole");
            fields.Add("Type", "getRole");
            fields.Add("OldCode", strUserCode);
            MssqlDAL dal = new MssqlDAL(CostDB, "WF_EsignInvoice_CodeUpdate", fields);
            DataTable dt = dal.GetList().Tables[0];
            if (dt.Rows[0]["RoleCode"].ToString().Contains("Administrator"))
            {
                KFErrDeal.Visible = true;
            }
            else
            { KFErrDeal.Visible = false; }

            string User=dt.Rows[0]["UserName"].ToString();
            lblUserName.Text = User;
            this.statusStrip.Items[0].Text ="当前用户:"+ User+",时间："+DateTime.Now.ToString("yyyy/MM/dd HH:mm");
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AttachCmd_Click(object sender, EventArgs e)
        {
            //簽核附件更新
            KFErr.EsignAttachUpdate eAttach = new CostErrDeal.KFErr.EsignAttachUpdate();
            eAttach.Show();
        }

        private void eInvoiceCmd_Click(object sender, EventArgs e)
        {
            //子系統重拋
            KFErr.eInvoiceUpdate eInvoice = new CostErrDeal.KFErr.eInvoiceUpdate();
            eInvoice.Show();
        }

        private void EsignActor_Click(object sender, EventArgs e)
        {
            //簽核人替換
            KFErr.EsignActorUpdate eActor = new CostErrDeal.KFErr.EsignActorUpdate();
            eActor.Show();
        }

        private void EsignSearch_Click(object sender, EventArgs e)
        {
            //科法簽核狀態查詢
            KFErr.EInvoiceStatus eStatus = new CostErrDeal.KFErr.EInvoiceStatus();
            eStatus.Show();
        }

        private void KFPicture_Click(object sender, EventArgs e)
        {
            KFErr.frmKFPicture KFpic = new CostErrDeal.KFErr.frmKFPicture();
            KFpic.Show();
        }

        private void KFEsignDoc_Click(object sender, EventArgs e)
        {
            string strpath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            strpath = strpath + @"物流費用發票電子簽核系統文檔.doc";
            System.Diagnostics.Process.Start("explorer.exe", strpath);
        }

        private void KFEsignPicture_Click(object sender, EventArgs e)
        {
            string strpath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            strpath = strpath + @"發票簽核流程圖.gif";
            System.Diagnostics.Process.Start("explorer.exe", strpath);
        }

        private void btnActorInfo_Click(object sender, EventArgs e)
        {
            Esign.frmTiptopInfo ActorInfo = new CostErrDeal.Esign.frmTiptopInfo();
            ActorInfo.Show();
        }

        private void EsignCostChange_Click(object sender, EventArgs e)
        {
            //送簽代碼更新
            KFErr.EsignCodeUpdate eCode = new CostErrDeal.KFErr.EsignCodeUpdate();
            eCode.Show();
        }

        private void NewInvoiceChange_Click(object sender, EventArgs e)
        {
            //虛擬發票替換
            KFErr.frmInvoiceUpdate invoiceupdate = new CostErrDeal.KFErr.frmInvoiceUpdate();
            invoiceupdate.Show();
        }

        private void EalSendToSAP_Click(object sender, EventArgs e)
        {
            //預結報拋轉
            Esign.SendEalAccount SendEal = new CostErrDeal.Esign.SendEalAccount();
            SendEal.Show();
        }

        private void GetSignPath_Click(object sender, EventArgs e)
        {
            ////發票確認更新
            Esign.frmSignPath SignPath = new CostErrDeal.Esign.frmSignPath();
            SignPath.Visible = true;
        }

        private void KFInvoiceCostChange_Click(object sender, EventArgs e)
        {
            //簽核費用重新變更
            Esign.EsignInvoice CostEsign = new CostErrDeal.Esign.EsignInvoice();
            CostEsign.Visible = true;
        }


        private void CheckAccountSource_Click(object sender, EventArgs e)
        {
            //檢查預結報資料來源           
            KFErr.CheckAccountSource myAS = new CostErrDeal.KFErr.CheckAccountSource();
            myAS.Visible = true;
        }

        private void AdjustAPAmount_Click(object sender, EventArgs e)
        {
            BMS.AdjustAPAmount myAPA = new BMS.AdjustAPAmount();
            myAPA.Visible = true;
        }

        private void TiptopInfo_Click(object sender, EventArgs e)
        {
            Tool.frmTiptopInfo myTiptop = new Tool.frmTiptopInfo();
            myTiptop.Visible = true;
        }

        private void DBInfo_Click(object sender, EventArgs e)
        {
            if (new frmLogin().UserCode == "F1012647")
            {
                Tool.frmDBInfo myTiptop = new Tool.frmDBInfo();
                myTiptop.Visible = true;
            }
            else
            { MessageBox.Show("機密內容,非授權用戶無法查看!"); }
        }
     
        //private void EsignSearch_MouseHover(object sender, EventArgs e)
        //{
        //    this.toolTip.SetToolTip(this,"CheckData");
        //}      
       

    }
}
