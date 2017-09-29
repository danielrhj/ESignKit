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
    public partial class CheckAccountSource : Form
    {
        MssqlFields MF = new MssqlFields();
        string strSP = "P_BMS_ARGetCTNo";
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";
        private static string KFZXDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";
        private static string BMS = "server=10.134.97.38,3000;user id=prd_bmscost;password=prd_bmscost911;database=BmsCLDCost";

        public CheckAccountSource()
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

            //加入類型列表
            list.Clear();
            list.Add(new TransType { Values = "", MF = "--请选择---" });
            list.Add(new TransType { Values = "AccountNoPayee", MF = "結報單號及法人" });
            list.Add(new TransType { Values = "PreviewNo", MF = "PreviewNo" });
            list.Add(new TransType { Values = "Eal01", MF = "預結報單號" });

            ddlParType.DataSource = list;
            ddlParType.DisplayMember = "MF";
            ddlParType.ValueMember = "Values";
            ddlParType.SelectedValue = "AccountNoPayee";
        }

        #endregion 

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string SearchWay=ddlParType.SelectedValue.ToString();
            string ItemNo = txtItemValue.Text.Trim();
            string Action = "CheckAccountDataSourceBy" + SearchWay;
            if (ItemNo == "" || Action=="")
            {
                MessageBox.Show("提示：请输入要查询類型及号码!");
                this.txtItemValue.Focus();
                return;
            }

            MF.Clear();
            MF.Add("ActionType", Action);

            if (SearchWay == "AccountNoPayee")
            {
                MF.Add("AccountNo", ItemNo);
                MF.Add("Payee", txtPayee.Text.Trim());
            }
            else
            { MF.Add("PreviewNo", ItemNo); }

            MssqlDAL MD = new MssqlDAL(BMS, strSP, MF);
            DataSet ds = MD.GetList();

            gvBMS.DataSource = ds.Tables[0];
            this.gvARCommonFile.DataSource = ds.Tables[1];
            gvOTD.DataSource = ds.Tables[2];
            gv38EInv.DataSource = ds.Tables[3];
            gv29Cost.DataSource = ds.Tables[4];
            //this.gv29EInv.DataSource = ds.Tables[5];
        }


        private void gvARCommonFile_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && (e.ColumnIndex == 8))
            {
                int intCol = e.ColumnIndex;
                DataGridViewRow dgrCurrent = this.gvARCommonFile.Rows[e.RowIndex];
                string PreInvoiceNo = dgrCurrent.Cells[1].Value.ToString().Trim();
                              
                string ActionType = "", strData = "";
                bool bk = false;

                if (intCol == 8)
                {
                    ActionType = "UpdateARSendFlagByEal01";
                }               

                strData = dgrCurrent.Cells[intCol].Value.ToString().Trim(); 
                                
                MF.Clear();
                MF.Add("ActionType", ActionType);
                MF.Add("eal01", PreInvoiceNo);
                MF.Add("SendFlag", strData);
                MssqlDAL MD = new MssqlDAL(BMS, strSP, MF);
                bk = MD.UpdateSingle();
            }

        }

        private void GridInvoice1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvBMS.Rows.Count > 0 && e.RowIndex < gvBMS.Rows.Count - 1)
            {
                //DataGridViewRow dr = this.gvBMS.Rows[e.RowIndex];
                //MF.Clear();
                //MF.Add("ActionType", "SearchEsignData");
                //MF.Add("Action", "SearchByLotNo");
                //MF.Add("ItemNo", dr.Cells[0].Value.ToString());

                //MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);
                //DataSet ds = MD.GetList();
                ////GridInvoice1.DataSource = ds.Tables[0];
                //gvOTD.DataSource = ds.Tables[1];
                //gv38EInv.DataSource = ds.Tables[2];
                //gv29Cost.DataSource = ds.Tables[3];
                //MD = null;
            }
        }

        private void GridInvoice1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                //DataGridViewRow dr = gvBMS.Rows[e.Row.Index];

                //MF.Clear();
                //MF.Add("ActionType", "DeleteEsignData");
                //MF.Add("Action", "DeleteByLotNo");
                //MF.Add("ItemNo", dr.Cells[0].Value.ToString());

                //MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", MF);

                //bool bk = MD.UpdateSingle();
            }
        }

        private void gvBMS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int intCol = e.ColumnIndex;
            if (e.RowIndex > -1 && (intCol == 8 || intCol == 42 || intCol == 75))
            {
                DataGridViewRow dgrCurrent = this.gvBMS.Rows[e.RowIndex];
                string PreInvoiceNo = dgrCurrent.Cells[1].Value.ToString().Trim();

                string ActionType = "", strData = "";
                bool bk = false;

                if (intCol == 8)
                {
                    ActionType = "UpdateARSendFlagByEal01";
                }
                if (intCol == 42)
                {
                    PreInvoiceNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                    ActionType = "UpdateCFM2ByEal01";
                }
                if (intCol == 75)
                {
                    PreInvoiceNo = dgrCurrent.Cells[0].Value.ToString().Trim();
                    ActionType = "UpdateMaxCFMByEal01";
                }

                strData = dgrCurrent.Cells[intCol].Value.ToString().Trim();

                MF.Clear();
                MF.Add("ActionType", ActionType);
                MF.Add("eal01", PreInvoiceNo);
                MF.Add("SendFlag", strData);
                MssqlDAL MD = new MssqlDAL(BMS, strSP, MF);
                bk = MD.UpdateSingle();
            }

        }

      
    }
}
