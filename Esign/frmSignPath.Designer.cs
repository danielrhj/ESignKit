namespace CostErrDeal.Esign
{
    partial class frmSignPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gvSignpathDetail = new System.Windows.Forms.DataGridView();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeDescp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Users = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Groups = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Options = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ModifyBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSignPathSearch = new System.Windows.Forms.TextBox();
            this.gvSignPathHeader = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSignpathDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSignPathHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(160, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "簽核路徑查詢與維護";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(897, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 28);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "簽核路徑名稱:";
            // 
            // gvSignpathDetail
            // 
            this.gvSignpathDetail.AllowUserToAddRows = false;
            this.gvSignpathDetail.AllowUserToDeleteRows = false;
            this.gvSignpathDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSignpathDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailID,
            this.NodeID,
            this.NodeNo,
            this.NodeDescp,
            this.Signer,
            this.NodeType,
            this.Users,
            this.Groups,
            this.Options,
            this.ModifyBy,
            this.ModifyDate,
            this.CreateDate});
            this.gvSignpathDetail.Location = new System.Drawing.Point(477, 106);
            this.gvSignpathDetail.Name = "gvSignpathDetail";
            this.gvSignpathDetail.RowTemplate.Height = 23;
            this.gvSignpathDetail.Size = new System.Drawing.Size(907, 515);
            this.gvSignpathDetail.TabIndex = 30;
            // 
            // DetailID
            // 
            this.DetailID.DataPropertyName = "DetailID";
            this.DetailID.HeaderText = "DetailID";
            this.DetailID.Name = "DetailID";
            this.DetailID.Visible = false;
            // 
            // NodeID
            // 
            this.NodeID.DataPropertyName = "NodeID";
            this.NodeID.HeaderText = "NodeID";
            this.NodeID.Name = "NodeID";
            this.NodeID.Visible = false;
            // 
            // NodeNo
            // 
            this.NodeNo.DataPropertyName = "NodeNo";
            this.NodeNo.HeaderText = "NodeNo";
            this.NodeNo.Name = "NodeNo";
            // 
            // NodeDescp
            // 
            this.NodeDescp.DataPropertyName = "NodeDescp";
            this.NodeDescp.HeaderText = "NodeDescp";
            this.NodeDescp.Name = "NodeDescp";
            // 
            // Signer
            // 
            this.Signer.DataPropertyName = "Signer";
            this.Signer.HeaderText = "Signer";
            this.Signer.Name = "Signer";
            // 
            // NodeType
            // 
            this.NodeType.DataPropertyName = "NodeType";
            this.NodeType.HeaderText = "NodeType";
            this.NodeType.Name = "NodeType";
            // 
            // Users
            // 
            this.Users.DataPropertyName = "Users";
            this.Users.HeaderText = "Users";
            this.Users.Name = "Users";
            this.Users.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Users.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Groups
            // 
            this.Groups.DataPropertyName = "Groups";
            this.Groups.HeaderText = "Groups";
            this.Groups.Name = "Groups";
            this.Groups.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Groups.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Options
            // 
            this.Options.DataPropertyName = "Options";
            this.Options.HeaderText = "Options";
            this.Options.Name = "Options";
            this.Options.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Options.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ModifyBy
            // 
            this.ModifyBy.DataPropertyName = "ModifyBy";
            this.ModifyBy.HeaderText = "ModifyBy";
            this.ModifyBy.Name = "ModifyBy";
            // 
            // ModifyDate
            // 
            this.ModifyDate.DataPropertyName = "ModifyDate";
            dataGridViewCellStyle1.Format = "G";
            this.ModifyDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ModifyDate.HeaderText = "ModifyDate";
            this.ModifyDate.Name = "ModifyDate";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.CreateDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            // 
            // txtSignPathSearch
            // 
            this.txtSignPathSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignPathSearch.Location = new System.Drawing.Point(120, 63);
            this.txtSignPathSearch.Name = "txtSignPathSearch";
            this.txtSignPathSearch.Size = new System.Drawing.Size(571, 27);
            this.txtSignPathSearch.TabIndex = 31;
            // 
            // gvSignPathHeader
            // 
            this.gvSignPathHeader.AllowUserToAddRows = false;
            this.gvSignPathHeader.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSignPathHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvSignPathHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSignPathHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SignPath,
            this.BU,
            this.SiteCode});
            this.gvSignPathHeader.Location = new System.Drawing.Point(13, 106);
            this.gvSignPathHeader.Name = "gvSignPathHeader";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSignPathHeader.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvSignPathHeader.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gvSignPathHeader.RowTemplate.Height = 23;
            this.gvSignPathHeader.Size = new System.Drawing.Size(458, 515);
            this.gvSignPathHeader.TabIndex = 32;
            this.gvSignPathHeader.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSignPathHeader_RowEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SignPath
            // 
            this.SignPath.DataPropertyName = "SignPath";
            this.SignPath.HeaderText = "SignPath";
            this.SignPath.Name = "SignPath";
            this.SignPath.Width = 200;
            // 
            // BU
            // 
            this.BU.DataPropertyName = "BU";
            this.BU.HeaderText = "BU";
            this.BU.Name = "BU";
            // 
            // SiteCode
            // 
            this.SiteCode.DataPropertyName = "SiteCode";
            this.SiteCode.HeaderText = "SiteCode";
            this.SiteCode.Name = "SiteCode";
            this.SiteCode.Width = 50;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(955, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 28);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "保存明细";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtActor
            // 
            this.txtActor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActor.Location = new System.Drawing.Point(769, 63);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(122, 27);
            this.txtActor.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(700, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "簽核人:";
            // 
            // frmSignPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 627);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvSignPathHeader);
            this.Controls.Add(this.txtSignPathSearch);
            this.Controls.Add(this.gvSignpathDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Name = "frmSignPath";
            this.Text = "frmUpdateData";
            ((System.ComponentModel.ISupportInitialize)(this.gvSignpathDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSignPathHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvSignpathDetail;
        private System.Windows.Forms.TextBox txtSignPathSearch;
        private System.Windows.Forms.DataGridView gvSignPathHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn BU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeDescp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Users;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Groups;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Options;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label label1;
    }
}