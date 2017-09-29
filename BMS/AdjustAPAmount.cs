using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;

namespace CostErrDeal.BMS
{
    public partial class AdjustAPAmount : Form
    {
        MssqlFields MF = new MssqlFields();
        private static string strSP = "Web_CostMaintainAP_sp";
        private static string BMS = "server=10.134.97.38,3000;user id=prd_bmscost;password=prd_bmscost911;database=bmscldcost";
        private static string OTD = "server=10.134.97.38,3000;user id=daniel;password=daniel123;database=cldcost";

        public AdjustAPAmount()
        {
            InitializeComponent();
            BindComBox();            
        }

        #region TransType

        public class TransType
        {
            public string Values { get; set; }
            public string MF { get; set; }
        }

        //绑定数据
        private void BindComBox()
        {
            List<TransType> list = new List<TransType>();

            list.Clear();
            list.Add(new TransType { Values = "", MF = "--请选择---" });
            list.Add(new TransType { Values = "DMTruck", MF = "國內卡車" });
            list.Add(new TransType { Values = "EXTruck", MF = "出口卡車" });
            list.Add(new TransType { Values = "IMTruck", MF = "進口卡車" });
            list.Add(new TransType { Values = "DMAir", MF = "國內空運" });
            list.Add(new TransType { Values = "EXAir", MF = "出口空運" });
            list.Add(new TransType { Values = "IMAir", MF = "進口空運" });


            this.ddlTransType.DataSource = list;
            ddlTransType.DisplayMember = "MF";
            ddlTransType.ValueMember = "Values";
            ddlTransType.SelectedValue = "DMTruck";
            ddlParType.Text= "PreviewNo";
            groupBox4.Text = "運單費用信息(AP_" + ddlTransType.SelectedValue + "CostByShipment@BMS)";
        }

        #endregion 

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string AA = new frmLogin().UserCode;
            string ItemNo = txtItemValue.Text.Trim();
            string SearchType = ddlParType.Text.ToString();
            if (ItemNo == "" || SearchType == "")
            {
                MessageBox.Show("提示：请输入要查询類型及号码!");
                this.txtItemValue.Focus();
                return;
            }

            MF.Clear();
            MF.Add("ActionType", "GetDataList");
            MF.Add("SearchType", SearchType);
            MF.Add("ItemNo", ItemNo);
            MF.Add("TransType", this.ddlTransType.SelectedValue.ToString().Trim());

            MssqlDAL MD = new MssqlDAL(BMS, strSP, MF);
            DataSet ds = MD.GetList();

            DataTable dtHeader = ds.Tables[0];
            DataTable dtInvoice = ds.Tables[1];
            DataTable dtBLNo = ds.Tables[2];
            DataTable dtCost = ds.Tables[3];           

            if (dtHeader != null && dtHeader.Rows.Count > 0)
            {
                DataRow dr = dtHeader.Rows[0];
                lbPayInvoiceID.Text = dr["PayInvoiceID"].ToString();
                this.lbCNCY.Text = dr["Currency"].ToString();
                lbCost.Text = dr["Cost"].ToString();
                lbCreateDate.Text = dr["CreateDate"].ToString();
                lbPayee.Text = dr["Payee"].ToString();
                lbPayTo.Text = dr["PayTo"].ToString();
                this.lbPayToCode.Text = dr["PayToCode"].ToString();
                lbPreviewNo.Text = dr["PreviewNo"].ToString();

               

            }
            else{

                lbPayInvoiceID.Text ="未產生大發票";
                this.lbCNCY.Text = "";
                lbCost.Text = "";
                lbCreateDate.Text = "";
                lbPayee.Text = "";
                lbPayTo.Text = "";
                this.lbPayToCode.Text = "";
                lbPreviewNo.Text = "";
            }

            if (dtInvoice.Rows.Count > 1)
            { 
                DataRow drInvoice = dtInvoice.NewRow();
                drInvoice["usingCost"] = dtInvoice.Compute("sum(usingCost)", "").ToString();
                drInvoice["Cost"] = dtInvoice.Compute("sum(Cost)", "").ToString();
                drInvoice["PayToCode"] = "Total:";
                dtInvoice.Rows.Add(drInvoice); 
            }

            if (dtBLNo.Rows.Count > 1)
            {
                DataRow drInvoice = dtBLNo.NewRow();
                drInvoice["Cost"] = dtBLNo.Compute("sum(Cost)", "").ToString();
                drInvoice["BLNo"] = "Total:";
                dtBLNo.Rows.Add(drInvoice);
            }

            if (dtCost.Rows.Count > 1)
            {
                DataRow drInvoice = dtCost.NewRow();
                drInvoice["AllocCost"] = dtCost.Compute("sum(AllocCost)", "").ToString();
                drInvoice[5] = "Total:";
                dtCost.Rows.Add(drInvoice);
            }           


            gvPaymentInvNoHeader.DataSource = dtInvoice;
            gvBLNoHeader.DataSource = dtBLNo;
            gvCostByShipment.DataSource = dtCost;

            gvPaymentInvNoHeader.Columns[0].Visible = false;
            gvPaymentInvNoHeader.Columns[1].Visible = false;

            DataGridViewCellStyle myCellStyle = new DataGridViewCellStyle();
           
            myCellStyle.Format = "#,#.00";
            myCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //string GG = gvPaymentInvNoHeader.Rows[0].Cells[0].Value.ToString();
            gvPaymentInvNoHeader.Columns[7].DefaultCellStyle=myCellStyle;
            gvPaymentInvNoHeader.Columns[8].DefaultCellStyle = myCellStyle;
            gvPaymentInvNoHeader.Columns[9].DefaultCellStyle = myCellStyle;

            gvBLNoHeader.Columns[0].Visible = false;
            //string PaymentInvID = gvBLNoHeader.Rows[0].Cells[0].Value.ToString();
            gvBLNoHeader.Columns[8].DefaultCellStyle = myCellStyle;

            gvCostByShipment.Columns[6].DefaultCellStyle = myCellStyle;
            gvCostByShipment.Columns[7].DefaultCellStyle = myCellStyle;
            gvCostByShipment.Columns[8].DefaultCellStyle = myCellStyle;
            gvCostByShipment.Columns[9].DefaultCellStyle = myCellStyle;

        }


        #region gvPaymentInvNoHeader 事件

        private void gvPaymentInvNoHeader_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvPaymentInvNoHeader.Rows.Count > 0 && e.RowIndex < gvPaymentInvNoHeader.Rows.Count)
            {
                DataGridViewRow dr = this.gvPaymentInvNoHeader.Rows[e.RowIndex];
                MF.Clear();
                MF.Add("ActionType", "GetPaymentInvoiceDetail");
                MF.Add("ItemNo", dr.Cells[2].Value.ToString());
                MF.Add("TransType", this.ddlTransType.SelectedValue.ToString().Trim());

                MssqlDAL MD = new MssqlDAL(BMS, strSP, MF);
                DataSet ds = MD.GetList();

                DataTable dtBLNo = ds.Tables[0];
                DataTable dtCost = ds.Tables[1];   
                
                if (dtBLNo.Rows.Count > 1)
                {
                    DataRow drInvoice = dtBLNo.NewRow();
                    drInvoice["Cost"] = dtBLNo.Compute("sum(Cost)", "").ToString();
                    drInvoice["BLNo"] = "Total:";
                    dtBLNo.Rows.Add(drInvoice);
                }

                if (dtCost.Rows.Count > 1)
                {
                    DataRow drInvoice = dtCost.NewRow();
                    drInvoice["AllocCost"] = dtCost.Compute("sum(AllocCost)", "").ToString();
                    drInvoice["BLNO"] = "Total:";
                    dtCost.Rows.Add(drInvoice);
                }
                this.gvBLNoHeader.DataSource = ds.Tables[0];
                this.gvCostByShipment.DataSource = ds.Tables[1];
                MD = null;
            }
        }


        private void gvPaymentInvNoHeader_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                //DataGridViewRow dr = gvPaymentInvNoHeader.Rows[e.Row.Index];

                //MF.Clear();
                //MF.Add("ActionType", "DeleteEsignLoadingData");
                //MF.Add("LotNo", dr.Cells[0].Value.ToString());
                //MF.Add("LogRefNo", dr.Cells[1].Value.ToString());
                //MF.Add("BURefNo", dr.Cells[2].Value.ToString());

                //MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                //bool bk = MD.UpdateSingle();
            }
        }

        private void gvPaymentInvNoHeader_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int intCol = e.ColumnIndex;
            if (e.RowIndex > -1 && (intCol == 3 || intCol == 4 || intCol == 6 || intCol == 10 || intCol == 11 || intCol == 13 || intCol == 14 || intCol == 15 || intCol == 19 || intCol == 21 || intCol == 22))
            {
                //DataGridViewRow dgrCurrent = this.gvPaymentInvNoHeader.Rows[e.RowIndex];
                //string strLotNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                //string strLogRefNo = dgrCurrent.Cells[1].Value.ToString().Trim();
                //string strBURefNo = dgrCurrent.Cells[2].Value.ToString().Trim();
                //string ActionType = "", strData = "";

                //switch (e.ColumnIndex)
                //{
                //    case 3:
                //        {
                //            ActionType = "UpdatePayee";
                //            break;
                //        }
                //    case 4:
                //        {
                //            ActionType = "UpdateBU";
                //            break;
                //        }
                //    case 6:
                //        {
                //            ActionType = "UpdateCostCode";
                //            break;
                //        }
                //    case 10:
                //        {
                //            ActionType = "UpdatePlts";
                //            break;
                //        }
                //    case 11:
                //        {
                //            ActionType = "UpdateCtns";
                //            break;
                //        }
                //    case 13:
                //        {
                //            ActionType = "UpdateTotalCost";
                //            break;
                //        }
                //    case 14:
                //        {
                //            ActionType = "UpdateAllocCost";
                //            break;
                //        }
                //    case 15:
                //        {
                //            ActionType = "UpdateAllocRate";
                //            break;
                //        }
                //    case 19:
                //        {
                //            ActionType = "UpdateStorage";
                //            break;
                //        }
                //    case 21:
                //        {
                //            ActionType = "UpdateCV";
                //            break;
                //        }
                //    case 22:
                //        {
                //            ActionType = "UpdateTotalCV";
                //            break;
                //        }
                //    default: break; 
                //}

                //strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                //MF.Clear();
                //MF.Add("ActionType", ActionType);
                //MF.Add("LotNo", strLotNo);
                //MF.Add("LogRefNo", strLogRefNo);
                //MF.Add("BURefNo", strBURefNo);

                //MF.Add("Data", strData);

                //MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                //bool bk = MD.UpdateSingle();
            }
        }

        #endregion

        #region gvBLNoHeader 事件
        private void gvBLNoHeader_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex,intCol = e.ColumnIndex;
            if (rowid > -1 && (intCol == 7||intCol == 8))
            {
                DataGridViewRow dgrCurrent = this.gvBLNoHeader.Rows[rowid];
                string ItemId = dgrCurrent.Cells["ItemID"].Value.ToString().Trim();
                string PaymentInvId = dgrCurrent.Cells[0].Value.ToString().Trim();
                string ActionType = "", strData = "";

                switch (intCol)
                {
                    case 8:
                        {
                            ActionType = "UpdateAP_BLNoHeaderSingle";
                            break;
                        }
                  

                    default: break;
                }

                strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                MF.Clear();
                MF.Add("ActionType", ActionType);
                MF.Add("ItemID", ItemId);
                MF.Add("PaymentInvId", PaymentInvId);
                MF.Add("Cost", strData);

                MssqlDAL MD = new MssqlDAL(BMS, strSP, MF);

                bool bk = MD.UpdateSingle();
            }
        }

        #endregion

        private void gvCostByShipment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex, intCol = e.ColumnIndex;
            if (rowid > -1 && (intCol == 5 || intCol == 6 || intCol == 11))
            {
                //DataGridViewRow dgrCurrent = this.gvCostByShipment.Rows[rowid];
                //string strLotNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                //string strLogRefNo = dgrCurrent.Cells[1].Value.ToString().Trim();
                //string ActionType = "", strData = "";

                //switch (intCol)
                //{
                   
                //    case 5:
                //        {
                //            ActionType = "UpdateOrigin";
                //            break;
                //        }
                //    case 6:
                //        {
                //            ActionType = "UpdateDest";
                //            break;
                //        }
                //    case 11:
                //        {
                //            ActionType = "UpdateLogisticsCost";
                //            break;
                //        }

                //    default: break;
                //}
                //strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();
                //MF.Clear();
                //MF.Add("ActionType", ActionType);
                //MF.Add("LotNo", strLotNo);
                //MF.Add("LogRefNo", strLogRefNo);

                //MF.Add("Data", strData);

                //MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                //bool bk = MD.UpdateSingle();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ddlTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TransType=ddlTransType.SelectedValue.ToString();
            //if (TransType.EndsWith("Truck"))
            //{ 
                groupBox4.Text = "運單費用信息(AP_" + TransType + "CostByShipment@BMS)"; 
            //}

        }

       


      
    }
}
