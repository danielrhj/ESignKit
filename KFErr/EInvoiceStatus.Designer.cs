namespace CostErrDeal.KFErr
{
    partial class EInvoiceStatus
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
            this.dataGridStatus3 = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridStatus2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridStatus1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.hidLotNo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridStatus4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStatus3
            // 
            this.dataGridStatus3.AllowUserToAddRows = false;
            this.dataGridStatus3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatus3.Location = new System.Drawing.Point(6, 26);
            this.dataGridStatus3.Name = "dataGridStatus3";
            this.dataGridStatus3.RowTemplate.Height = 23;
            this.dataGridStatus3.Size = new System.Drawing.Size(503, 330);
            this.dataGridStatus3.TabIndex = 13;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(1029, 59);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 28);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(369, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "科法签核状态查询";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "发票号码:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(104, 59);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(453, 27);
            this.txtInvoiceNo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridStatus3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(538, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 362);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "该发票对应各签核节点";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridStatus2);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(17, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 362);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "该发票签核历史记录";
            // 
            // dataGridStatus2
            // 
            this.dataGridStatus2.AllowUserToAddRows = false;
            this.dataGridStatus2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatus2.Location = new System.Drawing.Point(6, 26);
            this.dataGridStatus2.Name = "dataGridStatus2";
            this.dataGridStatus2.RowTemplate.Height = 23;
            this.dataGridStatus2.Size = new System.Drawing.Size(497, 330);
            this.dataGridStatus2.TabIndex = 13;
            this.dataGridStatus2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStatus2_CellValueChanged);
            this.dataGridStatus2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridStatus2_UserDeletingRow);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridStatus1);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(17, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1494, 264);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "该发票对应当前签核状态";
            // 
            // dataGridStatus1
            // 
            this.dataGridStatus1.AllowUserToAddRows = false;
            this.dataGridStatus1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStatus1.Location = new System.Drawing.Point(3, 25);
            this.dataGridStatus1.Name = "dataGridStatus1";
            this.dataGridStatus1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridStatus1.RowTemplate.Height = 23;
            this.dataGridStatus1.Size = new System.Drawing.Size(1488, 236);
            this.dataGridStatus1.TabIndex = 13;
            this.dataGridStatus1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStatus1_CellValueChanged);
            this.dataGridStatus1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStatus1_RowEnter);
            this.dataGridStatus1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridStatus1_RowsAdded);
            this.dataGridStatus1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridStatus1_RowsRemoved);
            this.dataGridStatus1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridStatus1_UserDeletingRow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(563, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "签核号码(LotNo):";
            // 
            // txtLotNo
            // 
            this.txtLotNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotNo.Location = new System.Drawing.Point(710, 61);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(313, 27);
            this.txtLotNo.TabIndex = 16;
            // 
            // hidLotNo
            // 
            this.hidLotNo.AutoSize = true;
            this.hidLotNo.Location = new System.Drawing.Point(100, 615);
            this.hidLotNo.Name = "hidLotNo";
            this.hidLotNo.Size = new System.Drawing.Size(0, 12);
            this.hidLotNo.TabIndex = 22;
            this.hidLotNo.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl01});
            this.statusStrip1.Location = new System.Drawing.Point(0, 729);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1523, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl01
            // 
            this.tssl01.Name = "tssl01";
            this.tssl01.Size = new System.Drawing.Size(44, 17);
            this.tssl01.Text = "Ready";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridStatus4);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(1059, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 362);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "该发票对应可选签核人节点";
            // 
            // dataGridStatus4
            // 
            this.dataGridStatus4.AllowUserToAddRows = false;
            this.dataGridStatus4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatus4.Location = new System.Drawing.Point(9, 26);
            this.dataGridStatus4.Name = "dataGridStatus4";
            this.dataGridStatus4.RowTemplate.Height = 23;
            this.dataGridStatus4.Size = new System.Drawing.Size(434, 330);
            this.dataGridStatus4.TabIndex = 13;
            this.dataGridStatus4.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridStatus4_UserDeletingRow);
            // 
            // EInvoiceStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 751);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hidLotNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLotNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EInvoiceStatus";
            this.Text = "当前发票签核状态查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStatus3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridStatus2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridStatus1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.Label hidLotNo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl01;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridStatus4;
    }
}