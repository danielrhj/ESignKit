using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;
using System.Data.SqlClient;

namespace CostErrDeal.Esign
{
    public partial class frmSignPath : Form
    {
        MssqlFields MF = new MssqlFields();
        private static string KFCnn = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";
        private static string SP = "SP_EsignRuleManage";

        public frmSignPath()
        {
            InitializeComponent();
            BindComBox();
        }

        #region TransType

        public class TransType
        {
            public string Values { get; set; }
            public string Fields { get; set; }
        }

        //绑定数据
        private void BindComBox()
        {
            List<TransType> list = new List<TransType>();
            TransType d00 = new TransType { Values = "", Fields = "--请选择---" };
            TransType d0 = new TransType { Values = "DomesticAir", Fields = "出口國內空運" };
            TransType d1 = new TransType { Values = "DomesticSea", Fields = "出口國內海運" };
            TransType d2 = new TransType { Values = "DomesticExpress", Fields = "出口國內快遞" };
            TransType d3 = new TransType { Values = "ExportTruck", Fields = "出口卡車" };
            TransType d4 = new TransType { Values = "ExportAir", Fields = "出口國際空運" };
            TransType d5 = new TransType { Values = "ExportSea", Fields = "出口國際海運" };
            TransType d6 = new TransType { Values = "ExportExpress", Fields = "出口國際快遞" };
            TransType d7 = new TransType { Values = "ImportTruck", Fields = "進口卡車" };
            TransType d8 = new TransType { Values = "ImportAir", Fields = "進口空運" };
            TransType d9 = new TransType { Values = "ImportSea", Fields = "進口海運" };
            TransType d10 = new TransType { Values = "ImportExpress", Fields = "進口快遞" };
            TransType d11 = new TransType { Values = "HubOut", Fields = "中轉倉出倉" };
            TransType d12 = new TransType { Values = "HubIn", Fields = "中轉倉進倉" };
            TransType d13 = new TransType { Values = "Declaration", Fields = "香港申報" };
            TransType d14 = new TransType { Values = "PickUp/Prepayment", Fields = "提貨代墊" };
            TransType d15 = new TransType { Values = "ImportExtras", Fields = "進口雜費" };
            TransType d16 = new TransType { Values = "HKLocal", Fields = "香港轉Local" };
            TransType d17 = new TransType { Values = "DomesticHub", Fields = "國內倉儲" };

            list.Add(new TransType { Values = "", Fields = "--请选择---" });
            list.Add(new TransType { Values = "DomesticAir", Fields = "出口國內空運" });
            
        }

        #endregion
      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                MF.Clear();
                MF.Add("Option", "GetRulesListByKit");
                MF.Add("RulePath", this.txtSignPathSearch.Text.Trim());
                MF.Add("UserCode", this.txtActor.Text.Trim());

                MssqlDAL MD = new MssqlDAL(KFCnn, SP, MF);
                DataTable dt = MD.GetDataTable();
                this.gvSignPathHeader.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查詢出錯！" + ex.Message);
                this.gvSignPathHeader.DataSource = null;
                this.gvSignpathDetail.DataSource = null;
            }
        }


        private void gvSignPathHeader_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gvSignPathHeader.Rows.Count > 0)
            {
                try
                {
                    DataGridViewRow dr = this.gvSignPathHeader.Rows[e.RowIndex];
                    MF.Clear();
                    MF.Add("Option", "GetRuleDetailByID");
                    MF.Add("RuleID", dr.Cells[0].Value.ToString());

                    MssqlDAL MD = new MssqlDAL(KFCnn, SP, MF);
                    DataTable dt = MD.GetDataTable();
                    this.gvSignpathDetail.DataSource = dt;
                    MD = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("顯示明細出錯！" + ex.Message);
                    this.gvSignpathDetail.DataSource = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.gvSignpathDetail.EndEdit();
            DataTable dt = (gvSignpathDetail.DataSource as DataTable).GetChanges();

            if (dt != null && dt.Rows.Count > 0)
            {

                string strSelect = "SELECT ID_ as DetailID,ASSIGNER_ as Signer FROM WF_DEFAULT_RULE_DETAIL";
                SqlDataAdapter SD = new SqlDataAdapter(strSelect, KFCnn);
                SqlCommandBuilder SB = new SqlCommandBuilder(SD);//一次搞定所有新增，修改，删除

                SD.Update(dt);dt.AcceptChanges();
                //this.gvSignpathDetail.Update();
                
            }
        }
    }
}
