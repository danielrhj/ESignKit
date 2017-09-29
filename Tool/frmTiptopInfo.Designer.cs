namespace CostErrDeal.Tool
{
    partial class frmTiptopInfo
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CorpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBConn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgPayee = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayeeCodeNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavePayee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(497, 46);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 28);
            this.btnQuery.TabIndex = 26;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "片語:";
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.AcceptsReturn = true;
            this.txtSearchInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInfo.Location = new System.Drawing.Point(89, 47);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.Size = new System.Drawing.Size(386, 27);
            this.txtSearchInfo.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CorpID,
            this.DBConn,
            this.DBProvider});
            this.dataGridView1.Location = new System.Drawing.Point(10, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 421);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // CorpID
            // 
            this.CorpID.DataPropertyName = "CorpID";
            this.CorpID.HeaderText = "CorpID";
            this.CorpID.Name = "CorpID";
            this.CorpID.Width = 80;
            // 
            // DBConn
            // 
            this.DBConn.DataPropertyName = "DNSString";
            this.DBConn.HeaderText = "DBConn";
            this.DBConn.Name = "DBConn";
            this.DBConn.Width = 1000;
            // 
            // DBProvider
            // 
            this.DBProvider.DataPropertyName = "DBProvider";
            this.DBProvider.HeaderText = "DBProvider";
            this.DBProvider.Name = "DBProvider";
            this.DBProvider.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(257, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "預結報連接查詢";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(579, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "(支持模糊查询)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1271, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(811, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgPayee
            // 
            this.dgPayee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPayee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.PayeeType,
            this.PayeeCodeNew,
            this.Creator});
            this.dgPayee.Location = new System.Drawing.Point(10, 529);
            this.dgPayee.Name = "dgPayee";
            this.dgPayee.RowTemplate.Height = 23;
            this.dgPayee.Size = new System.Drawing.Size(973, 68);
            this.dgPayee.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "GC_AP_Payee@BMS/OTD";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PayeeCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "PayeeCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PayeeAbbr";
            this.dataGridViewTextBoxColumn2.HeaderText = "PayeeAbbr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PayeeName";
            this.dataGridViewTextBoxColumn3.HeaderText = "PayeeName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // PayeeType
            // 
            this.PayeeType.DataPropertyName = "PayeeType";
            this.PayeeType.HeaderText = "PayeeType";
            this.PayeeType.Name = "PayeeType";
            // 
            // PayeeCodeNew
            // 
            this.PayeeCodeNew.DataPropertyName = "PayeeCodeNew";
            this.PayeeCodeNew.HeaderText = "PayeeCodeNew";
            this.PayeeCodeNew.Name = "PayeeCodeNew";
            // 
            // Creator
            // 
            this.Creator.DataPropertyName = "Creator";
            this.Creator.HeaderText = "Creator";
            this.Creator.Name = "Creator";
            // 
            // btnSavePayee
            // 
            this.btnSavePayee.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSavePayee.Location = new System.Drawing.Point(1001, 529);
            this.btnSavePayee.Name = "btnSavePayee";
            this.btnSavePayee.Size = new System.Drawing.Size(95, 28);
            this.btnSavePayee.TabIndex = 38;
            this.btnSavePayee.Text = "保存法人信息";
            this.btnSavePayee.UseVisualStyleBackColor = true;
            this.btnSavePayee.Click += new System.EventHandler(this.btnSavePayee_Click);
            // 
            // frmTiptopInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 597);
            this.Controls.Add(this.btnSavePayee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgPayee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchInfo);
            this.Name = "frmTiptopInfo";
            this.Text = "frmTiptopInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBConn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBProvider;
        private System.Windows.Forms.DataGridView dgPayee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayeeCodeNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.Button btnSavePayee;
    }
}