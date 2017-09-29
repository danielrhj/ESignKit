using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DIYGENS.COM.DBLL.Mssql;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Configuration;


namespace CostErrDeal.KFErr
{
    public partial class EsignCodeUpdate : Form
    {
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";
        private static string KFZXDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";
        private static string BMS = ConfigurationManager.AppSettings["BMS"].ToString();
        MssqlFields fields = new MssqlFields();
        System.Data.DataTable dt = new System.Data.DataTable();
        MssqlDAL dal = null;

        public EsignCodeUpdate()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            ArrayList list = new ArrayList();
            list.Add(new DictionaryEntry("", ""));
            list.Add(new DictionaryEntry("Payee", "法人(Payee)更新"));
            list.Add(new DictionaryEntry("PaytoCode", "厂商代码(PaytoCode)更新"));
            list.Add(new DictionaryEntry("Forwarder", "请款人(Forwarder)更新"));
            list.Add(new DictionaryEntry("AccCode", "科目代码(AccCode)更新"));
            list.Add(new DictionaryEntry("CostCode", "费用代码(CostCode)更新"));
            list.Add(new DictionaryEntry("TaxCode", "稅別代码(TaxCode)更新"));
            list.Add(new DictionaryEntry("PreviewNo", "大發票(PreviewNo)更新"));
            list.Add(new DictionaryEntry("TransDate", "交易日期(TransDate)更新"));

            ddlUpdateType.DataSource = list;
            ddlUpdateType.DisplayMember = "Value";
            ddlUpdateType.ValueMember = "Key";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (txtInvoiceNo.Text.Trim() + txtPreviewNo.Text.Trim() == "")
            {
                MessageBox.Show("[警告] 必须输入要查询的单号!");
                txtInvoiceNo.Focus();
                return;
            }
            fields.Clear();
            fields.Add("ActionType", "SearchEsignData");
            fields.Add("InvoiceNo", txtInvoiceNo.Text.Trim());
            fields.Add("PreviewNo", txtPreviewNo.Text.Trim());
            fields.Add("Type", chkTax.Checked ? "TaxCode" : "");

            try
            {
                dal = new MssqlDAL(CostDB, "WF_EsignInvoice_CodeUpdate", fields);
                dt = dal.GetList().Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry,系統超時!"+ex.Message.ToString());
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count <= 0 || txtOrderNo.Text.Trim() == "" || ddlUpdateType.SelectedValue.ToString() == "")
            {
                MessageBox.Show("抱歉,没有你要更新的任何资料!");
                txtOrderNo.Focus();
                return;
            }

            fields.Clear();
            if (chkTax.Checked == true)
                fields.Add("ActionType", "UpdateEsginCode_TaxCode");
            else
                fields.Add("ActionType", "UpdateEsginCode");
            fields.Add("TransType", dataGridView1.Rows[0].Cells["TransType"].Value);
            fields.Add("OldCode", txtOldCode.Text.Trim());
            fields.Add("OrderNo", txtOrderNo.Text.Trim());
            fields.Add("InvoiceNo", txtInvoiceNo.Text.Trim());
            fields.Add("PreviewNo", txtPreviewNo.Text.Trim());
            fields.Add("Type", ddlUpdateType.SelectedValue.ToString());

            if (MessageBox.Show("你确定要更新成当前的代码吗?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dal = new MssqlDAL(CostDB, "WF_EsignInvoice_CodeUpdate", fields);
                    dal.UpdateSingle();
                    MessageBox.Show("代码更新成功！！");
                }
                catch
                {
                    MessageBox.Show("親,更新失敗,系統繁忙中......");
                }
            }

            btnQuery_Click(null, null);
        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked)
            {
                ddlUpdateType.SelectedIndex = 6;
                txtPreviewNo.Text = "";
                txtPreviewNo.Enabled = false;
                ddlUpdateType.Enabled = false;
                lblMsg.Visible = true;
            }
            else
            {
                lblMsg.Visible = false;
                ddlUpdateType.SelectedIndex = 0;
                txtPreviewNo.Enabled = true;
                ddlUpdateType.Enabled = true;
            }
        }

        private void btnExcelUpdate_Click(object sender, EventArgs e)
        {            
            string actionType=ddlUpdateType.SelectedValue.ToString();
            OpenFileDialog myOFD = new OpenFileDialog();
            myOFD.Title = "请选择文件";            
            myOFD.Filter = "所有文件(*.*)|*.*";
            //if (myOFD.ShowDialog() == DialogResult.OK)
            //{       
            //    string selectfile = myOFD.FileName;
            //    NPOI2011 myExcel = new NPOI2011(selectfile);
            //    System.Data.DataTable dt = myExcel.GetDataTable(selectfile);
            //    bool bk = new MssqlDAL(BMS, "truncate table Jiang_SignTemp").UpdateSingle();
            //    string strSQL = "select BuInvoiceNo,CostCode from Jiang_SignTemp";      

            //    if (actionType == "CostCode")
            //    {             
            //        dt.Columns[0].ColumnName = "BuInvoiceNo"; dt.Columns[1].ColumnName = "CostCode";                    
            //        System.Data.DataTable dtTarget = new MssqlDAL(BMS, strSQL).GetDataTable();

            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            dtTarget.Rows.Add(dt.Rows[i].ItemArray);  //添加数据行            
            //        }

            //        SqlDataAdapter SD = new SqlDataAdapter(strSQL, BMS);
            //        SqlCommandBuilder SB = new SqlCommandBuilder(SD);
            //        int AA = SD.Update(dtTarget);

            //        if (AA == dt.Rows.Count)
            //        {
            //            //更新BMS
            //            strSQL = "exec p_BMS_ExcelUpdate @ActionType='UpdateCostCode'";
            //            bool bk1 = new MssqlDAL(BMS, strSQL).UpdateSingle();

            //            //更新KF
            //            strSQL = "exec WF_EsignInvoice_CodeUpdate @ActionType='UpdateCostCodeFromBMSAR'";
            //            bool bk2 = new MssqlDAL(KFZXDB, strSQL).UpdateSingle();

            //            if (bk1 && bk2)
            //            { MessageBox.Show("更新費用代碼成功", "更新費用代碼"); }
            //            else
            //            { MessageBox.Show("更新費用代碼失敗", "更新費用代碼"); }
            //        }
            //        else
            //        { MessageBox.Show("導入資料到BMS失敗", "導入資料"); }
            //    }
            //    else if (actionType == "PreviewNo")
            //    {
            //        strSQL = "select BuInvoiceNo,PreviewNo from Jiang_SignTemp";
            //        dt.Columns[0].ColumnName = "BuInvoiceNo"; dt.Columns[1].ColumnName = "PreviewNo";
            //        System.Data.DataTable dtTarget = new MssqlDAL(BMS, strSQL).GetDataTable();

            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            dtTarget.Rows.Add(dt.Rows[i].ItemArray);  //添加数据行            
            //        }

            //        SqlDataAdapter SD = new SqlDataAdapter(strSQL, BMS);
            //        SqlCommandBuilder SB = new SqlCommandBuilder(SD);
            //        int AA = SD.Update(dtTarget);

            //        //更新KF
            //        strSQL = "exec WF_EsignInvoice_CodeUpdate @ActionType='UpdatePreviewNoFromBMS'";
            //        bool bk2 = new MssqlDAL(KFZXDB, strSQL).UpdateSingle();

            //        if (bk2)
            //        { MessageBox.Show("更新大發票成功", "更新大發票"); }
            //    }
            //    else if (actionType == "Payee")
            //    {
            //        strSQL = "select BuInvoiceNo,NewPayee from Jiang_SignTemp";
            //        dt.Columns[0].ColumnName = "BuInvoiceNo"; dt.Columns[1].ColumnName = "NewPayee";
            //        System.Data.DataTable dtTarget = new MssqlDAL(BMS, strSQL).GetDataTable();

            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            dtTarget.Rows.Add(dt.Rows[i].ItemArray);  //添加数据行            
            //        }

            //        SqlDataAdapter SD = new SqlDataAdapter(strSQL, BMS);
            //        SqlCommandBuilder SB = new SqlCommandBuilder(SD);
            //        int AA = SD.Update(dtTarget);
                    
            //        //更新BMS
            //        strSQL = "exec p_BMS_ExcelUpdate @ActionType='UpdatePayeeAR'";
            //        bool bk1 = new MssqlDAL(BMS, strSQL).UpdateSingle();

            //        //更新KF
            //        strSQL = "exec WF_EsignInvoice_CodeUpdate @ActionType='UpdatePayeeFromBMS'";
            //        bool bk2 = new MssqlDAL(KFZXDB, strSQL).UpdateSingle();
                   
            //        if (bk2)
            //        { MessageBox.Show("更新付款法人成功", "更新付款法人"); }
            //    }

            //    else if (actionType == "TransDate")
            //    {
            //        strSQL = "select BuInvoiceNo,TransDate from Jiang_SignTemp";
            //        dt.Columns[0].ColumnName = "BuInvoiceNo"; dt.Columns[1].ColumnName = "TransDate";
            //        System.Data.DataTable dtTarget = new MssqlDAL(BMS, strSQL).GetDataTable();

            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            dtTarget.Rows.Add(dt.Rows[i].ItemArray);  //添加数据行            
            //        }

            //        SqlDataAdapter SD = new SqlDataAdapter(strSQL, BMS);
            //        SqlCommandBuilder SB = new SqlCommandBuilder(SD);
            //        int AA = SD.Update(dtTarget);

            //        ////更新BMS
            //        //strSQL = "exec p_BMS_ExcelUpdate @ActionType='UpdatePayeeAR'";
            //        //bool bk1 = new MssqlDAL(BMS, strSQL).UpdateSingle();

            //        //更新KF
            //        strSQL = "exec WF_EsignInvoice_CodeUpdate @ActionType='UpdateTransDateFromBMS'";
            //        bool bk2 = new MssqlDAL(KFZXDB, strSQL).UpdateSingle();

            //        if (bk2)
            //        { MessageBox.Show("更新交易時間成功", "更新交易時間"); }
            //    }

            //    myExcel = null;
            //    myOFD = null;
            //    GC.Collect();
            //}

        }
    }
}
