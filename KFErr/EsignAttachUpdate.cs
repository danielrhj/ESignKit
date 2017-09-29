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
    public partial class EsignAttachUpdate : Form
    {
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";
        private static string KFZXDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";

        public EsignAttachUpdate()
        {
            InitializeComponent();
        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            MssqlFields fields = new MssqlFields();
            DataTable dt = new DataTable();
            int sum = 0;
            if (txtInvoiceNo.Text.Trim() == "" && txtPreviewNo.Text.Trim() == "" && txtBLNo.Text.Trim() == "")
            {
                MessageBox.Show("必須輸入指定的單號才能更新附件!");
                return;
            }
            else
            {
                try
                {
                    fields.Clear();
                    fields.Add("ActionType", "UpdateAttachByType");
                    fields.Add("InvoiceNo", txtInvoiceNo.Text.Trim());
                    fields.Add("PreviewNo", txtPreviewNo.Text.Trim());
                    fields.Add("OrderNo", txtBLNo.Text.Trim());
                    MssqlDAL dal = new MssqlDAL(CostDB, "WF_EsignInvoice_CodeUpdate", fields);
                    dt = dal.GetList().Tables[0];
                    this.dataGridView1.DataSource = dt;

                    MessageBox.Show("科法签核附件更新成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出錯了 鴨梨山大啊" + ex.Message.ToString());
                }
            }

        }

        private void AddLinkColumn()
        {
            DataGridViewLinkColumn links = new DataGridViewLinkColumn();

            links.HeaderText = "网址";
            links.DataPropertyName = "网址";
            links.ActiveLinkColor = Color.White;
            links.LinkBehavior = LinkBehavior.SystemDefault;
            links.LinkColor = Color.Blue;
            links.TrackVisitedState = true;
            links.VisitedLinkColor = Color.YellowGreen;

            dataGridView1.Columns.Add(links);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                System.Diagnostics.Process.Start("iexplore.exe", this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value.ToString());
            }
        }
    }
}
