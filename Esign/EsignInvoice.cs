using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;
using System.Configuration;

namespace CostErrDeal.Esign
{
    public partial class EsignInvoice : Form
    {
        MssqlFields MF = new MssqlFields();
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";
        private static string KFZXDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";
        private static string BMSDB = ConfigurationManager.AppSettings["BMS"].ToString();


        public class TransType
        {
            public string Values { get; set; }
            public string Fields { get; set; }
        }

        public EsignInvoice()
        {
            InitializeComponent();

            List<TransType> list = new List<TransType>();

            list.Add(new TransType { Values = "InvoiceNo", Fields = "InvoiceNo" });
            list.Add(new TransType { Values = "LotNo", Fields = "LotNo" });
            list.Add(new TransType { Values = "PreviewNo", Fields = "PreviewNo" });
             this.ddlParType.DataSource = list;
             ddlParType.DisplayMember = "Fields";
             ddlParType.ValueMember = "Values";
        }
     

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string AA = new frmLogin().UserCode;
            string ItemNo = txtItemValue.Text.Trim();
            string Action ="SearchBy"+ddlParType.SelectedValue.ToString();
            if (ItemNo == "" || Action=="")
            {
                MessageBox.Show("提示：请输入要查询類型及号码!");
                this.txtItemValue.Focus();
                return;
            }

            MF.Clear();
            MF.Add("ActionType", "SearchEsignData");
            MF.Add("Action", Action);
            MF.Add("ItemNo", ItemNo);

            MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
            DataSet ds = MD.GetList();

            GridInvoice1.DataSource = ds.Tables[0];
            GridInvoice2.DataSource = ds.Tables[1];
            GridInvoice3.DataSource = ds.Tables[2];
            GridInvoice4.DataSource = ds.Tables[3];
            GridInvoice5.DataSource = ds.Tables[4];
        }

        private void btnUpdateAttach_Click(object sender, EventArgs e)
        {
            string ItemNo = txtItemValue.Text.Trim();
            string Action = "By" + ddlParType.SelectedValue.ToString();
            if (ItemNo == "" || Action == "")
            {
                MessageBox.Show("提示：更新類型及号码不能为空哦!");
                this.txtItemValue.Focus();
                return;
            }

            try
            {
                MF.Clear();
                MF.Add("ActionType", "FillAttachListFromCost");
                MF.Add("TransType", Action);
                MF.Add("ItemNo", ItemNo);

                MssqlDAL MD = new MssqlDAL(KFZXDB, "GC_WLSignData_sp", MF);
                bool bk = MD.UpdateSingle();
                //MessageBox.Show("附件更新成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("出錯了 鴨梨山大啊" + ex.Message.ToString());
            }
           
        }       

        private void btnKFUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要更新科法簽核中的費用嗎?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MssqlDAL dal = null;

                //1.InvoiceInfo
                MF.Clear();
                MF.Add("ActionType", "updateEsignCost");
                MF.Add("TransType", "InvoiceInfo");
                MF.Add("LotNo", GridInvoice1.Rows[0].Cells["LotNo"].Value.ToString());
                MF.Add("StdCost", GridInvoice1.Rows[0].Cells["StdCost"].Value.ToString());
                MF.Add("Cost", GridInvoice1.Rows[0].Cells["Cost"].Value.ToString());

                dal = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
                dal.UpdateSingle();

                //2.LoadingInfo
                for (int i = 0; i < GridInvoice2.Rows.Count - 1; i++)
                {
                    MF.Clear();
                    MF.Add("ActionType", "updateEsignCost");
                    MF.Add("TransType", "LoadingInfo");
                    MF.Add("LotNo", GridInvoice2.Rows[i].Cells["LotNo"].Value.ToString());
                    MF.Add("Cost", GridInvoice2.Rows[i].Cells["TotalCost"].Value.ToString());
                    MF.Add("AllocRate", GridInvoice2.Rows[i].Cells["AllocRate"].Value.ToString());
                    MF.Add("AllocCost", GridInvoice2.Rows[i].Cells["AllocCost"].Value.ToString());
                    MF.Add("LogRefNo", GridInvoice2.Rows[i].Cells["LogRefNo"].Value.ToString());
                    MF.Add("BURefNo", GridInvoice2.Rows[i].Cells["BURefNo"].Value.ToString());

                    dal = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
                    dal.UpdateSingle();
                }

                //3.LogisticsInfo
                for (int i = 0; i < GridInvoice4.Rows.Count - 1; i++)
                {
                    MF.Clear();
                    MF.Add("ActionType", "updateEsignCost");
                    MF.Add("TransType", "LogisticsInfo");
                    MF.Add("LotNo", GridInvoice4.Rows[i].Cells["LotNo"].Value.ToString());
                    MF.Add("LogRefNo", GridInvoice4.Rows[i].Cells["LogRefNo"].Value.ToString());
                    MF.Add("Cost", GridInvoice4.Rows[i].Cells["Cost"].Value.ToString());

                    dal = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
                    dal.UpdateSingle();
                }

                //4.CostInfo
                for (int i = 0; i < GridInvoice3.Rows.Count - 1; i++)
                {
                    MF.Clear();
                    MF.Add("ActionType", "updateEsignCost");
                    MF.Add("TransType", "CostInfo");
                    MF.Add("LotNo", GridInvoice3.Rows[i].Cells["LotNo"].Value.ToString());
                    MF.Add("Cost", GridInvoice3.Rows[i].Cells["Cost"].Value.ToString());
                    MF.Add("LogRefNo", GridInvoice3.Rows[i].Cells["LogRefNo"].Value.ToString());
                    MF.Add("ItemNo", GridInvoice3.Rows[i].Cells["ItemNo"].Value.ToString());

                    dal = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
                    dal.UpdateSingle();
                }
            }
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GridInvoice1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //11=PreViewNo,12=AccountNo,13=AccountDate
            int intCol = e.ColumnIndex;


            if (e.RowIndex > -1 && (intCol == 2 || intCol == 5 || intCol == 7 || intCol == 8 || intCol == 11 || intCol == 12 || intCol == 13 || intCol == 14 || intCol == 16 || intCol == 18 || intCol == 30))
            {
                DataGridViewRow dgrCurrent = this.GridInvoice1.Rows[e.RowIndex];
                string strLotNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                string strInvoiceNo = dgrCurrent.Cells[1].Value.ToString().Trim();

                string strPreViewNo = dgrCurrent.Cells[11].Value.ToString().Trim();
                string strAccountNo = dgrCurrent.Cells[12].Value.ToString().Trim();
                string strAccountDate = dgrCurrent.Cells[13].Value.ToString().Trim();

                strAccountDate =strAccountDate.Length>0?Convert.ToDateTime(strAccountDate).ToString("yyyy/MM/dd"):"";
                string strAF = dgrCurrent.Cells[28].Value.ToString().Trim();
                string strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                string ActionType = "";
                bool bk = false;


                if (intCol == 2)
                {
                    ActionType = "updateBU";
                    strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                }
                if (intCol == 5)
                {
                    ActionType = "updateForwarder";
                }
                else if (intCol == 7)
                {
                    ActionType = "updateCost";
                    strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                }
                else if (intCol == 8)
                {
                    ActionType = "updateStdCost";
                    strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                }

                else if (intCol == 11)
                {
                    ActionType = "updatePreviewNo";
                    strData = strPreViewNo;
                }
                else if (intCol == 12)
                {
                    ActionType = "updateAccountNo";
                    strData = strAccountNo;
                }
                else if (intCol == 13)
                {
                    ActionType = "updateAccountDate";
                    strData = strAccountDate;
                }
                else if (intCol == 14)
                {
                    ActionType = "updateSender";
                    strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                }
                else if (intCol == 16)
                {
                    ActionType = "updateSignpath";
                    strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                }

                else if (intCol == 30)
                {
                    ActionType = "UpdateAllowanceFlag";
                    strData = strAF;
                }              

                if (ActionType.Length > 1)
                {
                    try
                    {
                        MssqlFields MF = new MssqlFields();
                        MF.Clear();
                        MF.Add("ActionType", ActionType);
                        MF.Add("LotNo", strLotNo);
                        MF.Add("InvoiceNo", strInvoiceNo);
                        MF.Add("Data",strData);

                        if (intCol == 2)
                        {
                            MF.Add("Type", "0");    //更新GC_ESign_InvoiceInfo裏面的BillingBu
                        }

                        MssqlDAL dal = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
                        bk = dal.UpdateSingle();

                        if ((intCol == 11)&&strInvoiceNo.StartsWith("FSK"))
                        {
                            UpdatestrDataBMS(strInvoiceNo, ActionType, strData);
                        }

                    }
                    catch (Exception ex)
                    {
                        string AA = ex.Message;
                    }
                }

            }

        }

        private void UpdatestrDataBMS(string strInvoiceNo, string ActionType, string strData)
        {
            try
            {
                MssqlFields MF = new MssqlFields();
                MF.Clear();
                MF.Add("ActionType", ActionType);
                MF.Add("BUInvoiceNo", strInvoiceNo);
                MF.Add("Data", strData);

                MssqlDAL dal = new MssqlDAL(BMSDB, "P_BMS_ARGetCTNo", MF);
                bool bk = dal.UpdateSingle();
               
            }
            catch (Exception ex)
            {
                string AA = ex.Message;
            }
        }

       
        private void GridInvoice1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridInvoice1.Rows.Count > 0 && e.RowIndex < GridInvoice1.Rows.Count)
            {
                DataGridViewRow dr = this.GridInvoice1.Rows[e.RowIndex];
                MF.Clear();
                MF.Add("ActionType", "SearchEsignData");
                MF.Add("Action", "SearchByLotNo");
                MF.Add("ItemNo", dr.Cells[0].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
                DataSet ds = MD.GetList();
                //GridInvoice1.DataSource = ds.Tables[0];
                GridInvoice2.DataSource = ds.Tables[1];
                GridInvoice3.DataSource = ds.Tables[2];
                GridInvoice4.DataSource = ds.Tables[3];
                GridInvoice5.DataSource = ds.Tables[4];
                MD = null;
            }
        }

        private void GridInvoice1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                DataGridViewRow dr = GridInvoice1.Rows[e.Row.Index];

                MF.Clear();
                MF.Add("ActionType", "DeleteEsignData");
                MF.Add("Action", "DeleteByLotNo");
                MF.Add("ItemNo", dr.Cells[0].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                bool bk = MD.UpdateSingle();
            }
        }


        private void GridInvoice2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                DataGridViewRow dr = GridInvoice2.Rows[e.Row.Index];

                MF.Clear();
                MF.Add("ActionType", "DeleteEsignLoadingData");
                MF.Add("LotNo", dr.Cells[0].Value.ToString());
                MF.Add("LogRefNo", dr.Cells[1].Value.ToString());
                MF.Add("BURefNo", dr.Cells[2].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                bool bk = MD.UpdateSingle();
            }
        }

        private void GridInvoice2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int intCol = e.ColumnIndex;
            if (e.RowIndex > -1 && (intCol == 3 || intCol == 4 || intCol == 6 || intCol == 9 || intCol == 11  || intCol == 12|| intCol == 13 || intCol == 15 || intCol == 19 || intCol == 21 || intCol == 22))
            {
                DataGridViewRow dgrCurrent = this.GridInvoice2.Rows[e.RowIndex];
                string strLotNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                string strLogRefNo = dgrCurrent.Cells[1].Value.ToString().Trim();
                string strBURefNo = dgrCurrent.Cells[2].Value.ToString().Trim();
                string ActionType = "", strData = "";

                switch (e.ColumnIndex)
                {
                    case 3:
                        {
                            ActionType = "UpdatePayee";
                            break;
                        }
                    case 4:
                        {
                            ActionType = "UpdateBU";
                            break;
                        }
                    case 6:
                        {
                            ActionType = "UpdateCostCode";
                            break;
                        }
                    case 9:
                        {
                            ActionType = "UpdatePlts";
                            break;
                        }
                    case 11:
                        {
                            ActionType = "UpdateCtns";
                            break;
                        }
                    case 12:
                        {
                            ActionType = "UpdateTotalCost";
                            break;
                        }
                    case 13:
                        {
                            ActionType = "UpdateAllocCost";
                            break;
                        }
                    case 15:
                        {
                            ActionType = "UpdateAllocRate";
                            break;
                        }
                    case 19:
                        {
                            ActionType = "UpdateStorage";
                            break;
                        }
                    case 21:
                        {
                            ActionType = "UpdateCV";
                            break;
                        }
                    case 22:
                        {
                            ActionType = "UpdateTotalCV";
                            break;
                        }
                    default: break; 
                }

                strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                MF.Clear();
                MF.Add("ActionType", ActionType);
                MF.Add("LotNo", strLotNo);
                MF.Add("LogRefNo", strLogRefNo);
                MF.Add("BURefNo", strBURefNo);

                MF.Add("Data", strData);

                if (intCol == 4) { MF.Add("Type", "1"); }   //更新GC_ESign_LoadingInfo中的兩個BU

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                bool bk = MD.UpdateSingle();
            }
        }

        private void GridInvoice3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex,intCol = e.ColumnIndex;
            if (rowid > -1 && (intCol == 7||intCol == 8))
            {
                DataGridViewRow dgrCurrent = this.GridInvoice3.Rows[rowid];
                string strLotNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                string strLogRefNo = dgrCurrent.Cells[1].Value.ToString().Trim();
                string strItemNo = dgrCurrent.Cells[2].Value.ToString().Trim();
                string ActionType = "", strData = "";

                switch (intCol)
                {
                    case 7:
                        {
                            ActionType = "UpdateItemCost";
                            break;
                        }
                    case 8:
                        {
                            ActionType = "UpdateAccCode";
                            break;
                        }
                    
                    default: break;
                }

                strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                MF.Clear();
                MF.Add("ActionType", ActionType);
                MF.Add("LotNo", strLotNo);
                MF.Add("LogRefNo", strLogRefNo);
                MF.Add("ItemNo", strItemNo);

                MF.Add("Data", strData);

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                bool bk = MD.UpdateSingle();
            }
        }

        private void GridInvoice4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex, intCol = e.ColumnIndex;
            if (rowid > -1 && (intCol == 5 || intCol == 6||intCol == 8 || intCol == 11))
            {
                DataGridViewRow dgrCurrent = this.GridInvoice4.Rows[rowid];
                string strLotNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                string strLogRefNo = dgrCurrent.Cells[1].Value.ToString().Trim();
                string ActionType = "", strData = "";

                switch (intCol)
                {
                   
                    case 5:
                        {
                            ActionType = "UpdateOrigin";
                            break;
                        }
                    case 6:
                        {
                            ActionType = "UpdateDest";
                            break;
                        }
                    case 8:
                        {
                            ActionType = "UpdateTransdate";
                            break;
                        }
                    case 11:
                        {
                            ActionType = "UpdateLogisticsCost";
                            break;
                        }

                    default: break;
                }
                strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                MF.Clear();
                MF.Add("ActionType", ActionType);
                MF.Add("LotNo", strLotNo);
                MF.Add("LogRefNo", strLogRefNo);

                MF.Add("Data", strData);

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                bool bk = MD.UpdateSingle();
            }
        }

        private void btnCancelPreviewNo_Click(object sender, EventArgs e)
        {
            if (txtNewPreviewNo.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("[慎重]你确定要刪除已有的大發票號碼嗎?", this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
                { return; }
            }

            MF.Clear();
            MF.Add("ActionType", "UpdatePreviewNoBatch");
            MF.Add("PreviewNo", txtItemValue.Text.Trim());
            MF.Add("Data", txtNewPreviewNo.Text.Trim());


            MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

            bool bk = MD.UpdateSingle();

            btnQuery_Click(null, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }       

        private void GridInvoice5_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex, GridInvoice5);
        }

        private void GridInvoice5_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex, GridInvoice5);
        }

        private void RefreshDataGridViewLineNumber(int index,DataGridView dg)
        {
            for (int i = index; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void GridInvoice1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex, GridInvoice1);
        }

        private void GridInvoice1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshDataGridViewLineNumber(e.RowIndex, GridInvoice1);
        } 
      
    }
}
