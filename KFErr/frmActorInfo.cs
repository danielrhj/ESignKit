using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DIYGENS.COM.DBLL.Mssql;

namespace CostErrDeal.Esign
{
    public partial class frmTiptopInfo : Form
    {
        MssqlFields fields = new MssqlFields();
        private static string CostDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=COST";
        private static string KFZXDB = "server=10.134.97.29,3000;user id=daniel;password=daniel123;database=CentralIBPMFramework";

        public frmTiptopInfo()
        {
            InitializeComponent(); 
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.txtActorInfo.Text.Trim() == "")
            {
                MessageBox.Show("提示：请输入要查询的签核人工号或姓名!");
                this.txtActorInfo.Focus();
                return;
            }

            MssqlDAL dal1 = new MssqlDAL(KFZXDB, "select * from STARTERKIT_USER_INFO where (user_id+user_name) like '%" + txtActorInfo.Text.Trim() + "%'");
                       
            dataGridView1.DataSource = dal1.GetList().Tables[0];
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string UserID = "", Comment = "", ActionType = "";
            int intCol = e.ColumnIndex;

            if (e.RowIndex > -1 && (intCol == 2 || intCol == 4 || intCol == 7 || intCol == 9 || intCol == 10 || intCol == 11 || intCol == 17))
            {
                DataGridViewRow dgrCurrent = this.dataGridView1.Rows[e.RowIndex];
                UserID = dgrCurrent.Cells[0].Value.ToString();
                Comment = dgrCurrent.Cells[8].Value.ToString();

                fields.Clear();
                if (intCol == 2)
                {
                    ActionType = "UpdateUsername";
                } 
                if (intCol == 4)
                {
                    ActionType = "Updatedepartment";
                }
                if (intCol == 7)
                {
                    ActionType = "Updateroles";
                }
                if (intCol == 9)
                {
                    ActionType = "UpdateFormMail";
                }
                if (intCol == 10)
                {
                    ActionType = "Updatedistrict";
                }
                if (intCol == 11)
                {
                    ActionType = "UpdatePosition";
                }
                if (intCol == 17)
                {
                    ActionType = "UpdateDelAttach";
                }

                fields.Add("ActionType", ActionType);
                fields.Add("OldActor", UserID);
                fields.Add("Data", dgrCurrent.Cells[intCol].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                bool bk = MD.UpdateSingle();
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                DataGridViewRow dr = dataGridView1.Rows[e.Row.Index];

                fields.Clear();
                fields.Add("ActionType", "DeleteUser");
                fields.Add("OldActor", dr.Cells[0].Value.ToString());

                MssqlDAL MD = new MssqlDAL(KFZXDB, "WF_EsignInvoice_CodeUpdate", fields);

                bool bk = MD.UpdateSingle();
            }
        }
    }
}
