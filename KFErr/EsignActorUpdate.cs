using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;
//using OfficeOpenXml;

namespace CostErrDeal.KFErr
{
    public partial class EsignActorUpdate : Form
    {
        private static string KFZXDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework;min pool size=4;max pool size=10000;packet size=3072";
        MssqlFields fields = new MssqlFields();
        MssqlDAL dal = null;

        public EsignActorUpdate()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtActor.Text.Trim() + txtInvoiceNo.Text.Trim()=="")
            {
                MessageBox.Show("[警告] 必须输入要查询的签核人或发票 !");
                txtActor.Focus();
                return;
            }

            fields.Clear();
            fields.Add("ActionType", "GetActor_RUNNIGN");
            fields.Add("LotNo", txtActor.Text.Trim());
            fields.Add("Approvepath", this.txtApprovePath.Text.Trim());
            fields.Add("InvoiceNo", txtInvoiceNo.Text.Trim());

            try
            {
                dal = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);
                DataSet ds = dal.GetList();
                dataGridStatus1.DataSource = ds.Tables[0];
                dataGridStatus2.DataSource = ds.Tables[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("出錯了 鴨梨山大啊" + ex.Message.ToString());
            }
        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            if (txtActor.Text.Trim() + txtInvoiceNo.Text.Trim() == "")
            {
                MessageBox.Show("[警告] 必须输入要查询的签核人或发票! ");
                txtActor.Focus();
                return;
            }
            if (txtActor_Update.Text.Trim() == "")
            {
                MessageBox.Show("[提示] 请输入要替换的签核人！");
                txtActor_Update.Focus();
                return;
            }
            if (MessageBox.Show("你确定要更新成当前的签核人吗?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fields.Clear();

                string OldActor=txtActor.Text.Trim();
                string NewActor=txtActor_Update.Text.Trim();
                string InvoiceNo=txtInvoiceNo.Text.Trim();

                if (OldActor.Length > 1 && NewActor.Length > 1 && InvoiceNo.Length == 0)
                {
                    fields.Add("ActionType", "UpdateActor_RUNNIGNBatch");
                    fields.Add("OldActor", OldActor);
                    fields.Add("NewActor", NewActor);
                    fields.Add("Approvepath", txtApprovePath.Text.Trim());///
                }
                else
                {                
                    fields.Add("ActionType", "UpdateActor_RUNNIGN");
                    fields.Add("LotNo", OldActor);
                    fields.Add("InvoiceNo", InvoiceNo);
                    fields.Add("OrderNo", NewActor);
                }
                try
                {
                    dal = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);
                    dal.UpdateSingle();
                    MessageBox.Show("批量更新成功！");
                    btnQuery_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出錯了 鴨梨山大啊" + ex.Message.ToString());
                }
            }
        }

        
        private void EsignActorUpdate_Load(object sender, EventArgs e)
        {

        }

        private void dataGridStatus1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridStatus1.Rows.Count > 0)
            {
                try
                {
                    DataGridViewRow dr = this.dataGridStatus1.Rows[e.RowIndex];
                    fields.Clear();
                    fields.Add("ActionType", "GetSignPath");
                    fields.Add("RouteName", dr.Cells[2].Value.ToString());

                    MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);
                    DataTable dt = MD.GetDataTable();
                    this.dataGridStatus2.DataSource = dt;
                    MD = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("顯示簽核路徑出錯！" + ex.Message);
                    this.dataGridStatus2.DataSource = null;
                }
            }
        }

        private void dataGridStatus1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex);
        }

        private void dataGridStatus1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex);
        }

        private void RefreshDataGridViewLineNumber(int index)
        {
            for (int i = index; i < dataGridStatus1.Rows.Count; i++)
            {
                this.dataGridStatus1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        } 
    }
}
