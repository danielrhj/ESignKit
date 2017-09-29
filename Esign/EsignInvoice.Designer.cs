namespace CostErrDeal.Esign
{
    partial class EsignInvoice
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
            System.Windows.Forms.Button btnUpdateAttach;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridInvoice1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridInvoice2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridInvoice3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridInvoice4 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtItemValue = new System.Windows.Forms.TextBox();
            this.btnCancelPreviewNo = new System.Windows.Forms.Button();
            this.btnKFUpdate = new System.Windows.Forms.Button();
            this.ddlParType = new System.Windows.Forms.ComboBox();
            this.txtNewPreviewNo = new System.Windows.Forms.TextBox();
            this.GridInvoice5 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            btnUpdateAttach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateAttach
            // 
            btnUpdateAttach.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnUpdateAttach.Location = new System.Drawing.Point(604, 17);
            btnUpdateAttach.Name = "btnUpdateAttach";
            btnUpdateAttach.Size = new System.Drawing.Size(87, 28);
            btnUpdateAttach.TabIndex = 24;
            btnUpdateAttach.Text = "更新附件";
            btnUpdateAttach.UseVisualStyleBackColor = true;
            btnUpdateAttach.Click += new System.EventHandler(this.btnUpdateAttach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridInvoice1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1308, 163);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1.签核发票信息列表GC_ESign_InvoiceInfo";
            // 
            // GridInvoice1
            // 
            this.GridInvoice1.AllowUserToAddRows = false;
            this.GridInvoice1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInvoice1.Location = new System.Drawing.Point(6, 22);
            this.GridInvoice1.Name = "GridInvoice1";
            this.GridInvoice1.RowTemplate.Height = 23;
            this.GridInvoice1.Size = new System.Drawing.Size(1295, 135);
            this.GridInvoice1.TabIndex = 13;
            this.GridInvoice1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInvoice1_CellValueChanged);
            this.GridInvoice1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInvoice1_RowEnter);
            this.GridInvoice1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridInvoice1_RowsAdded);
            this.GridInvoice1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridInvoice1_RowsRemoved);
            this.GridInvoice1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GridInvoice1_UserDeletingRow);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridInvoice2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 171);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "签核发票装货信息列表GC_ESign_LoadingInfo";
            // 
            // GridInvoice2
            // 
            this.GridInvoice2.AllowUserToAddRows = false;
            this.GridInvoice2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInvoice2.Location = new System.Drawing.Point(9, 21);
            this.GridInvoice2.Name = "GridInvoice2";
            this.GridInvoice2.RowTemplate.Height = 23;
            this.GridInvoice2.Size = new System.Drawing.Size(1292, 137);
            this.GridInvoice2.TabIndex = 13;
            this.GridInvoice2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInvoice2_CellValueChanged);
            this.GridInvoice2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GridInvoice2_UserDeletingRow);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridInvoice3);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1308, 186);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "签核发票费用信息列表GC_ESign_CostInfo";
            this.groupBox3.UseWaitCursor = true;
            // 
            // GridInvoice3
            // 
            this.GridInvoice3.AllowUserToAddRows = false;
            this.GridInvoice3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInvoice3.Location = new System.Drawing.Point(9, 22);
            this.GridInvoice3.Name = "GridInvoice3";
            this.GridInvoice3.RowTemplate.Height = 23;
            this.GridInvoice3.Size = new System.Drawing.Size(1292, 158);
            this.GridInvoice3.TabIndex = 13;
            this.GridInvoice3.UseWaitCursor = true;
            this.GridInvoice3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInvoice3_CellValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridInvoice4);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 593);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1308, 174);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "签核发票物流信息列表GC_ESign_LogisticsInfo";
            // 
            // GridInvoice4
            // 
            this.GridInvoice4.AllowUserToAddRows = false;
            this.GridInvoice4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInvoice4.Location = new System.Drawing.Point(9, 23);
            this.GridInvoice4.Name = "GridInvoice4";
            this.GridInvoice4.RowTemplate.Height = 23;
            this.GridInvoice4.Size = new System.Drawing.Size(1292, 145);
            this.GridInvoice4.TabIndex = 13;
            this.GridInvoice4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInvoice4_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "发票明細查询";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(530, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 28);
            this.btnQuery.TabIndex = 23;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtItemValue
            // 
            this.txtItemValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemValue.Location = new System.Drawing.Point(353, 18);
            this.txtItemValue.Name = "txtItemValue";
            this.txtItemValue.Size = new System.Drawing.Size(164, 27);
            this.txtItemValue.TabIndex = 21;
            this.txtItemValue.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            // 
            // btnCancelPreviewNo
            // 
            this.btnCancelPreviewNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelPreviewNo.Location = new System.Drawing.Point(838, 18);
            this.btnCancelPreviewNo.Name = "btnCancelPreviewNo";
            this.btnCancelPreviewNo.Size = new System.Drawing.Size(138, 28);
            this.btnCancelPreviewNo.TabIndex = 31;
            this.btnCancelPreviewNo.Text = "批量更新大發票";
            this.btnCancelPreviewNo.UseVisualStyleBackColor = true;
            this.btnCancelPreviewNo.Click += new System.EventHandler(this.btnCancelPreviewNo_Click);
            // 
            // btnKFUpdate
            // 
            this.btnKFUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKFUpdate.Location = new System.Drawing.Point(1031, 774);
            this.btnKFUpdate.Name = "btnKFUpdate";
            this.btnKFUpdate.Size = new System.Drawing.Size(92, 28);
            this.btnKFUpdate.TabIndex = 32;
            this.btnKFUpdate.Text = "科法更新";
            this.btnKFUpdate.UseVisualStyleBackColor = true;
            this.btnKFUpdate.Visible = false;
            this.btnKFUpdate.Click += new System.EventHandler(this.btnKFUpdate_Click);
            // 
            // ddlParType
            // 
            this.ddlParType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlParType.FormattingEnabled = true;
            this.ddlParType.Items.AddRange(new object[] {
            "InvoiceNo;InvoiceNo",
            "LotNo;LotNo",
            "PreviewNo;PreviewNo"});
            this.ddlParType.Location = new System.Drawing.Point(232, 18);
            this.ddlParType.Name = "ddlParType";
            this.ddlParType.Size = new System.Drawing.Size(115, 26);
            this.ddlParType.TabIndex = 30;
            // 
            // txtNewPreviewNo
            // 
            this.txtNewPreviewNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPreviewNo.Location = new System.Drawing.Point(697, 18);
            this.txtNewPreviewNo.Name = "txtNewPreviewNo";
            this.txtNewPreviewNo.Size = new System.Drawing.Size(130, 27);
            this.txtNewPreviewNo.TabIndex = 33;
            // 
            // GridInvoice5
            // 
            this.GridInvoice5.AllowUserToAddRows = false;
            this.GridInvoice5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInvoice5.Location = new System.Drawing.Point(21, 797);
            this.GridInvoice5.Name = "GridInvoice5";
            this.GridInvoice5.RowTemplate.Height = 23;
            this.GridInvoice5.Size = new System.Drawing.Size(1142, 99);
            this.GridInvoice5.TabIndex = 13;
            this.GridInvoice5.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridInvoice5_RowsAdded);
            this.GridInvoice5.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridInvoice5_RowsRemoved);
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(12, 773);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1163, 123);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "1.签核发票附件列表GC_ESign_AttachInfo";
            // 
            // EsignInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1345, 878);
            this.Controls.Add(this.GridInvoice5);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtNewPreviewNo);
            this.Controls.Add(this.btnKFUpdate);
            this.Controls.Add(this.btnCancelPreviewNo);
            this.Controls.Add(this.ddlParType);
            this.Controls.Add(btnUpdateAttach);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtItemValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EsignInvoice";
            this.Text = "EsignInvoice";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridInvoice1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridInvoice2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridInvoice3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView GridInvoice4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtItemValue;
        private System.Windows.Forms.Button btnCancelPreviewNo;
        private System.Windows.Forms.Button btnKFUpdate;
        private System.Windows.Forms.ComboBox ddlParType;
        private System.Windows.Forms.TextBox txtNewPreviewNo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView GridInvoice5;
    }
}