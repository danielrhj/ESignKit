using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DIYGENS.COM.DBLL.Mssql;

namespace CostErrDeal.KFErr
{
    public partial class frmInvoiceUpdate : Form
    {
        MssqlFields fields = new MssqlFields();
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";

        public frmInvoiceUpdate()
        {
            InitializeComponent();
        }

        private void UploadFile()
        {
            try
            {
                string strFilePath = txtUpLoadfile.Text;
                string strFileType = strFilePath.Substring(strFilePath.LastIndexOf(".") + 1);
                DataSet ds = new DataSet();

                if (strFilePath == "") { MessageBox.Show("溫馨提示:請選擇要導入的發票文件!"); return; }
                if (strFileType.ToLower() != "xls") { MessageBox.Show("溫馨提示:你導入的文件不合法!"); return; }
                //通過oledb打開Excel檔－賦給DataSet

                string mystring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + strFilePath + "';Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
                OleDbConnection connxls = new OleDbConnection(mystring);

                connxls.Open();
                DataTable schemaTable = connxls.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                string tableName = schemaTable.Rows[0][2].ToString().Trim();

                string TempSQL = "";
                TempSQL = "select distinct * from [" + tableName + "]";
                OleDbDataAdapter mydb = new OleDbDataAdapter(TempSQL, connxls);
                mydb.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                lblCount.Text = "待更新发票列表:共 " + ds.Tables[0].Rows.Count.ToString() + " 笔";
                btnUpdate.Enabled = true;
            }
            catch
            {
                MessageBox.Show("[上传失败]:文档无法读取!");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\Patch";
            openFileDialog1.Filter = "All files (*.*)|*.*|txt files (*.xls)|*.xls";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtUpLoadfile.Text = openFileDialog1.FileName;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要更新到新的发票吗?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string strsql = "", oldInvoiceNo = "", newInvoiceNo = "";
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    oldInvoiceNo = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                    newInvoiceNo = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
                    if (oldInvoiceNo == "" || oldInvoiceNo == "")
                        continue;

                    if (strsql == "")
                        strsql = " select distinct '" + oldInvoiceNo + "' as oldInvoice,'" + newInvoiceNo + "' as newInvoiceNo ";
                    else
                        strsql = strsql + " union select '" + oldInvoiceNo + "' as oldInvoice,'" + newInvoiceNo + "' as newInvoiceNo ";
                }
                try
                {
                    if (strsql == "")
                    {
                        MessageBox.Show("溫馨提示:没有任何可更新的發票!"); return;
                    }
                    fields.Clear();
                    fields.Add("ActionType", "BatchUpdateInvoiceNo");
                    fields.Add("OrderNo", strsql);
                    MssqlDAL dal = new MssqlDAL(CostDB, "WF_EsignInvoice_CodeUpdate", fields);
                    DataSet ds = dal.GetList();
                    dataGridView1.DataSource = ds.Tables[0];
                    lblCount.Text = "更新失败发票列表:共 " + ds.Tables[0].Rows.Count.ToString() + " 笔";

                    lblOK.Text = "恭喜,你已成功更新 " + ds.Tables[1].Rows[0][0].ToString() + " 笔发票!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新失败！" + ex.Message.ToString());
                }
            }
        }
        private void btnExecCode_Click(object sender, EventArgs e)
        {
            try
            {
                lblOK.Text = "";
                string strCoding = txtCoding.Text.Trim();
                if (strCoding == "")
                {

                    strCoding = "select '' as '虛擬發票','' as '真實發票' ";
                    //MessageBox.Show("溫馨提示:没有任何可执行的代码!"); return;
                    lblCount.Text = "待更新发票列表:";
                }
                else
                    lblCount.Text = "";

                DataSet ds = new DataSet();
                MssqlDAL dal = new MssqlDAL(CostDB, strCoding);
                ds = dal.GetList();
                dataGridView1.DataSource = ds.Tables[0];
                lblCount.Text = lblCount.Text == "" ? "待更新发票列表:共 " + ds.Tables[0].Rows.Count.ToString() + " 笔" : lblCount.Text;
                txtCoding.Text = "";
                btnUpdate.Enabled = true;
            }
            catch
            {
                MessageBox.Show("错误,非法操作!"); return;
            }
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            UploadFile();
        }
    }
}
