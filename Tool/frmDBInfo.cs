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
    public partial class frmDBInfo : Form
    {        
        MssqlFields fields = new MssqlFields();
        private static string DBInfo = "server=10.134.154.176,3000;user id=jusda;password=jusda@Foxconn.com;database=JusdaRevenue";
        private static string strCnnBMS = ConfigurationManager.AppSettings["BMS"].ToString();
        private static DataTable dtOrigin;

        public frmDBInfo()
        {
            InitializeComponent(); 
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

        private void frmDBInfo_Load(object sender, EventArgs e)
        {
            DBInfoWS.Service1 ws = new DBInfoWS.Service1();
            dtOrigin = ws.GetTiptopDBInfo("k5218$%");
            dataGridView1.DataSource = dtOrigin;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];
                if (!dr.IsNewRow)
                {
                    string Payee = dr.Cells[2].Value.ToString().Trim();
                    string strSQL = "SELECT DBconn  FROM BA_ODBC where Entity='" + Payee + "'";

                    try
                    {
                        this.txtConn.Text = new MssqlDAL(DBInfo, strSQL).Rows[0].ToString();
                    }
                    catch (Exception ex)
                    {
                        this.txtConn.Text = "無連接信息.";
                    }
                }
            }
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            string strAA = this.txtQuery.Text.Trim();
            if (strAA.Length > 2)
            {   
                DataTable dtNew = dtOrigin.Clone();
                DataRow[] drArr = dtOrigin.Select("ead03 like '"+strAA+"%' or ead01 like '%"+strAA+"%'");

                if (drArr.Length == 0) { this.txtConn.Text = ""; }
                for (int i = 0; i < drArr.Length; i++)
                {
                    dtNew.ImportRow(drArr[i]);
                }
                dataGridView1.DataSource = dtNew;
            }
        }

     

    }
}
