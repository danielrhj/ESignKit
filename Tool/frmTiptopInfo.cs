using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;
using System.Data.SqlClient;
using System.Configuration;

namespace CostErrDeal.Tool
{
    public partial class frmTiptopInfo : Form
    {
        private static string strSP = "usp_WLZCSend_sp";
        MssqlFields fields = new MssqlFields();
        private static string DBInfo = "server=10.134.154.176,3000;user id=jusda;password=jusda@Foxconn.com;database=JUSDARevenue";
        private static string strCnnBMS = ConfigurationManager.AppSettings["BMS"].ToString();

        public frmTiptopInfo()
        {
            InitializeComponent(); 
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string searchText=this.txtSearchInfo.Text.Trim();
            if (searchText == "")
            {
                MessageBox.Show("提示：请输入要查询片語!");
                this.txtSearchInfo.Focus();
                return;
            }

            string strSQL = "exec " + strSP + " @ActionType='GetConnTiptop',@CorpID='" + searchText + "'";
            MssqlDAL dal1 = new MssqlDAL(DBInfo, strSQL);
                       
            dataGridView1.DataSource = dal1.GetDataTable();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //string CorpID = "", DBConn = "", Provider="", ActionType = "";
            //int intCol = e.ColumnIndex;

            //if (e.RowIndex > -1&&intCol>0 )
            //{
            //    DataGridViewRow dgrCurrent = this.dataGridView1.Rows[e.RowIndex];
            //    CorpID = dgrCurrent.Cells[0].Value.ToString();
            //    DBConn = dgrCurrent.Cells[1].Value.ToString();
            //    Provider = dgrCurrent.Cells[2].Value.ToString();

            //    fields.Clear();
            //    if (intCol == 1)
            //    {
            //        ActionType = "UpdateDBConn";
            //    } 
            //    if (intCol == 2)
            //    {
            //        ActionType = "UpdateProvider";
            //    }      

            //    fields.Add("ActionType", ActionType);
            //    fields.Add("CorpID", CorpID);
            //    fields.Add("Data", dgrCurrent.Cells[intCol].Value.ToString());

            //    MssqlDAL MD = new MssqlDAL(DBInfo, strSP, fields);

            //    bool bk = MD.UpdateSingle();
            //}
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
        //    if (e.Row.Index > -1)
        //    {
        //        DataGridViewRow dr = dataGridView1.Rows[e.Row.Index];

        //        fields.Clear();
        //        fields.Add("ActionType", "DeleteEntity");
        //        fields.Add("CorpID", dr.Cells[0].Value.ToString());

        //        MssqlDAL MD = new MssqlDAL(DBInfo, strSP, fields);

        //        bool bk = MD.UpdateSingle();
        //    }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex);
        }

        private void RefreshDataGridViewLineNumber(int index)
        {
            for (int i = index; i < dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            DataTable dt = (dataGridView1.DataSource as DataTable).GetChanges();

            if (dt != null && dt.Rows.Count > 0)
            {
                string strSelect = "select AutoID,Entity as CorpID,DBconn as DNSString,DBProvider from BA_ODBC";
                SqlDataAdapter SD = new SqlDataAdapter(strSelect, DBInfo);
                SqlCommandBuilder SB = new SqlCommandBuilder(SD);//一次搞定所有新增，修改，删除

                SD.Update(dt);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];
                if (!dr.IsNewRow)
                {
                    fields.Clear();
                    fields.Add("ActionType", "PayeeList");
                    fields.Add("PayeeHeader", dr.Cells[1].Value.ToString());

                    MssqlDAL MD = new MssqlDAL(strCnnBMS, "BA_Payee_sp", fields);
                    DataTable dt = MD.GetDataTable();
                    dgPayee.DataSource = dt;
                    MD = null;
                }
            }

        //string strSQL="exec BA_Payee_sp @ActionType='PayeeList',@PayeeHeader='"+strEntity+"'";
        }

        private void btnSavePayee_Click(object sender, EventArgs e)
        {
            dgPayee.EndEdit();
            DataTable dt = (dgPayee.DataSource as DataTable).GetChanges();

            if (dt != null && dt.Rows.Count > 0)
            {
                string strSelect = "select PayeeCode,PayeeAbbr,PayeeName,PayeeType,PayeeCodeNew,Creator from GC_AP_Payee";
                SqlDataAdapter SD = new SqlDataAdapter(strSelect, strCnnBMS);
                SqlCommandBuilder SB = new SqlCommandBuilder(SD);//一次搞定所有新增，修改，删除

                SD.Update(dt);

                //同步到OTD
                fields.Clear();
                fields.Add("ActionType", "PayeeListToOTD");
                MssqlDAL MD = new MssqlDAL(strCnnBMS, "BA_Payee_sp", fields);

                bool bk = MD.UpdateSingle();
            }
        } 

    }
}
