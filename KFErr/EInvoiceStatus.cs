using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;
using System.Collections;

namespace CostErrDeal.KFErr
{
    public partial class EInvoiceStatus : Form
    {
        private static string KFZXDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";
        //private static string KFZXDB = "server=10.130.14.247,3000;user id=daniel;password=daniel123;database=JusdaESignOld";
        private static string BMSDB = "server=10.134.97.38,3000;user id=prd_bmscost;password=prd_bmscost911;database=BmsCLDCost";
        MssqlFields fields = new MssqlFields();

        public EInvoiceStatus()
        {
            InitializeComponent();
        }

        private void InitData()
        {
            ArrayList list = new ArrayList();
            list.Add(new DictionaryEntry("", ""));
            list.Add(new DictionaryEntry("ESignToNext", "系统签核至下一人"));
            list.Add(new DictionaryEntry("普通件", "變更為普通件"));
            list.Add(new DictionaryEntry("特殊件", "變更為特殊件"));
            list.Add(new DictionaryEntry("Error", "變更為駁回"));
            list.Add(new DictionaryEntry("Running", "變更為簽核中"));
            list.Add(new DictionaryEntry("CANCEL", "變更為作廢"));


            //ddlTaskType.DataSource = list;
            //ddlTaskType.DisplayMember = "Value";
            //ddlTaskType.ValueMember = "Key";
            //this.statusStrip1.Items[0].Text = "Ready";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text.Trim() == "" && txtLotNo.Text.Trim() == "")
            {
                MessageBox.Show("提示：请输入要查询的发票号码或签核单号!");
                this.statusStrip1.Items[0].Text = "请输入要查询的发票号码或签核单号.";
                this.txtInvoiceNo.Focus();
                return;
            }

            fields.Clear();
            fields.Add("ActionType", "DisplayEsignStatus");
            fields.Add("InvoiceNo", txtInvoiceNo.Text.Trim());
            fields.Add("LotNo", txtLotNo.Text.Trim());

            try
            {
                MssqlDAL dal1 = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                DataSet ds = dal1.GetList();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridStatus1.DataSource = ds.Tables[0];

                    hidLotNo.Text = ds.Tables[0].Rows[0]["Form_"].ToString();
                    //dataGridStatus2.DataSource = ds.Tables[1];
                    //dataGridStatus3.DataSource = ds.Tables[2];
                    this.statusStrip1.Items[0].Text = "已查到 " + ds.Tables[0].Rows.Count.ToString() + " 笔资料。";
                }
                else
                {
                    this.statusStrip1.Items[0].Text = "没有查到符合条件的资料。";
                    dataGridStatus1.DataSource = null;
                    //dataGridStatus2.DataSource = null;
                    //dataGridStatus3.DataSource = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出錯了 鴨梨山大啊" + ex.Message.ToString());
                this.statusStrip1.Items[0].Text = "系统出现异常:" + ex.Message;

            }
        }

        private void dataGridStatus1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridStatus1.Rows.Count > 0 && e.RowIndex < dataGridStatus1.Rows.Count)
            {
                DataGridViewRow dr = this.dataGridStatus1.Rows[e.RowIndex];
                fields.Clear();
                fields.Add("ActionType", "GetSignHistoryAndSignPath");
                fields.Add("OrderNo", dr.Cells[4].Value.ToString());
                fields.Add("RouteName", dr.Cells[3].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);
                DataSet ds = MD.GetList();
                dataGridStatus2.DataSource = ds.Tables[0];
                dataGridStatus3.DataSource = ds.Tables[1];
                dataGridStatus4.DataSource = ds.Tables[2];
                if (ds.Tables[1].Rows.Count > 0)
                { dataGridStatus3.Rows[0].Selected = true; }
                MD = null;
            }

        }

        private void dataGridStatus1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                DataGridViewRow dr = dataGridStatus1.Rows[e.Row.Index];

                fields.Clear();
                fields.Add("ActionType", "DeleteInvoice");
                fields.Add("OrderNo", dr.Cells[4].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                bool bk = MD.UpdateSingle();
                //dataGridStatus1.Rows.Remove(dr);
                //btnQuery_Click(null, null);
            }
        }

        private void dataGridStatus4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                DataGridViewRow dr = dataGridStatus4.Rows[e.Row.Index];

                fields.Clear();
                fields.Add("ActionType", "DeleteNode4");
                fields.Add("UserCode", dr.Cells[1].Value.ToString());
                fields.Add("OrderNo", dr.Cells[4].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                bool bk = MD.UpdateSingle();
                //dataGridStatus1.Rows.Remove(dr);
                //btnQuery_Click(null, null);
            }
        }

        private void dataGridStatus1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string TaskID="",LotNo="",ActionType = "",Invoiceno="",SignID=""; 
            int intCol = e.ColumnIndex;

            if (e.RowIndex > -1 && (intCol == 11 || intCol == 9 || intCol == 7 || intCol == 6))
            {               
                DataGridViewRow dgrCurrent = this.dataGridStatus1.Rows[e.RowIndex];
                TaskID = dgrCurrent.Cells[4].Value.ToString();
                LotNo = dgrCurrent.Cells[5].Value.ToString();
                Invoiceno = dgrCurrent.Cells[1].Value.ToString();
                SignID = dgrCurrent.Cells[6].Value.ToString();


                fields.Clear();                
               
                if (intCol == 6)
                {
                    ActionType = "UpdateNode_";
                    fields.Add("ActionType", ActionType);
                    fields.Add("TaskID", TaskID);
                    fields.Add("OldActor", dgrCurrent.Cells[intCol].Value.ToString());

                }
                if (intCol == 7)
                {
                    ActionType = "UpdateActor_";
                    fields.Add("ActionType", ActionType);
                    fields.Add("TaskID", TaskID);
                    fields.Add("OldActor", dgrCurrent.Cells[intCol].Value.ToString());                
                }
                if (intCol == 9)
                {
                    ActionType = "UpdateCreator";
                    fields.Add("ActionType", ActionType);
                    fields.Add("TaskID", TaskID);
                    fields.Add("OldActor", dgrCurrent.Cells[intCol].Value.ToString());
                }
                
                if (intCol == 11)
                {
                    ActionType = "UpdateStatus_";
                    fields.Add("ActionType", ActionType);
                    fields.Add("TaskID", TaskID);
                    fields.Add("InvoiceNo", Invoiceno);
                    fields.Add("LotNo", LotNo);
                    fields.Add("OldActor", dgrCurrent.Cells[intCol].Value.ToString());
                }
                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                bool bk = MD.UpdateSingle();
                

                btnQuery_Click(null, null);

            }
        }

        private void dataGridStatus2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                DataGridViewRow dr = dataGridStatus2.Rows[e.Row.Index];

                fields.Clear();
                fields.Add("ActionType", "DeleteSignHistory");
                fields.Add("OrderNo", dr.Cells[0].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                bool bk = MD.UpdateSingle();
            }
        }

        private void dataGridStatus2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string HisID = "", Comment = "", ActionType="";
             if (e.RowIndex > -1 && (e.ColumnIndex == 8 ))
             {
                 int intCol = e.ColumnIndex;
                 DataGridViewRow dgrCurrent = this.dataGridStatus2.Rows[e.RowIndex];
                 HisID = dgrCurrent.Cells[0].Value.ToString();
                 Comment = dgrCurrent.Cells[8].Value.ToString();

                 fields.Clear();
                 if (intCol == 8)
                 {
                     ActionType = "UpdateSignComment";
                     fields.Add("ActionType", ActionType);
                     fields.Add("TaskID", HisID);
                     fields.Add("Data", dgrCurrent.Cells[intCol].Value.ToString());
                 }


                 MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                 bool bk = MD.UpdateSingle();
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
