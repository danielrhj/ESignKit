namespace CostErrDeal.BMS
{
    partial class AdjustAPAmount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvPaymentInvNoHeader = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvBLNoHeader = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gvCostByShipment = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtItemValue = new System.Windows.Forms.TextBox();
            this.btnKFUpdate = new System.Windows.Forms.Button();
            this.ddlParType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlTransType = new System.Windows.Forms.ComboBox();
            this.lbPayInvoiceID = new System.Windows.Forms.Label();
            this.lbPreviewNo = new System.Windows.Forms.Label();
            this.lbPayee = new System.Windows.Forms.Label();
            this.lbPayTo = new System.Windows.Forms.Label();
            this.lbPayToCode = new System.Windows.Forms.Label();
            this.lbCNCY = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentInvNoHeader)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBLNoHeader)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCostByShipment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvPaymentInvNoHeader);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 199);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "小发票信息(AP_PaymentInvNoHeader@BMS)";
            // 
            // gvPaymentInvNoHeader
            // 
            this.gvPaymentInvNoHeader.AllowUserToAddRows = false;
            this.gvPaymentInvNoHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvPaymentInvNoHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPaymentInvNoHeader.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvPaymentInvNoHeader.Location = new System.Drawing.Point(9, 21);
            this.gvPaymentInvNoHeader.Name = "gvPaymentInvNoHeader";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gvPaymentInvNoHeader.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gvPaymentInvNoHeader.RowTemplate.Height = 23;
            this.gvPaymentInvNoHeader.Size = new System.Drawing.Size(1148, 170);
            this.gvPaymentInvNoHeader.TabIndex = 13;
            this.gvPaymentInvNoHeader.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPaymentInvNoHeader_CellValueChanged);
            this.gvPaymentInvNoHeader.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gvPaymentInvNoHeader_UserDeletingRow);
            this.gvPaymentInvNoHeader.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPaymentInvNoHeader_RowEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvBLNoHeader);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(12, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1163, 231);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "運單费用匯總信息(AP_BLNoHeader@BMS)";
            // 
            // gvBLNoHeader
            // 
            this.gvBLNoHeader.AllowUserToAddRows = false;
            this.gvBLNoHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvBLNoHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBLNoHeader.Location = new System.Drawing.Point(9, 22);
            this.gvBLNoHeader.Name = "gvBLNoHeader";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gvBLNoHeader.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvBLNoHeader.RowTemplate.Height = 23;
            this.gvBLNoHeader.Size = new System.Drawing.Size(1148, 203);
            this.gvBLNoHeader.TabIndex = 13;
            this.gvBLNoHeader.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBLNoHeader_CellValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gvCostByShipment);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(12, 564);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1163, 203);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "運單費用信息(AP_**CostByShipment@BMS)";
            // 
            // gvCostByShipment
            // 
            this.gvCostByShipment.AllowUserToAddRows = false;
            this.gvCostByShipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvCostByShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCostByShipment.Location = new System.Drawing.Point(9, 23);
            this.gvCostByShipment.Name = "gvCostByShipment";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gvCostByShipment.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvCostByShipment.RowTemplate.Height = 23;
            this.gvCostByShipment.Size = new System.Drawing.Size(1148, 172);
            this.gvCostByShipment.TabIndex = 13;
            this.gvCostByShipment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCostByShipment_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "AP大發票金額調整";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(799, 18);
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
            this.txtItemValue.Location = new System.Drawing.Point(395, 18);
            this.txtItemValue.Name = "txtItemValue";
            this.txtItemValue.Size = new System.Drawing.Size(164, 27);
            this.txtItemValue.TabIndex = 21;
            // 
            // btnKFUpdate
            // 
            this.btnKFUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKFUpdate.Location = new System.Drawing.Point(1031, 774);
            this.btnKFUpdate.Name = "btnKFUpdate";
            this.btnKFUpdate.Size = new System.Drawing.Size(92, 28);
            this.btnKFUpdate.TabIndex = 32;
            this.btnKFUpdate.Text = "科法更新";
            this.btnKFUpdate.UseVisualStyleBackColor = true;
            this.btnKFUpdate.Visible = false;
            // 
            // ddlParType
            // 
            this.ddlParType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlParType.FormattingEnabled = true;
            this.ddlParType.Items.AddRange(new object[] {
            "PreviewNo",
            "InvoiceNo",
            "BLNo"});
            this.ddlParType.Location = new System.Drawing.Point(274, 18);
            this.ddlParType.Name = "ddlParType";
            this.ddlParType.Size = new System.Drawing.Size(115, 26);
            this.ddlParType.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(563, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "业务类型:";
            // 
            // ddlTransType
            // 
            this.ddlTransType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTransType.FormattingEnabled = true;
            this.ddlTransType.Location = new System.Drawing.Point(647, 18);
            this.ddlTransType.Name = "ddlTransType";
            this.ddlTransType.Size = new System.Drawing.Size(135, 26);
            this.ddlTransType.TabIndex = 30;
            this.ddlTransType.SelectedIndexChanged += new System.EventHandler(this.ddlTransType_SelectedIndexChanged);
            // 
            // lbPayInvoiceID
            // 
            this.lbPayInvoiceID.AutoSize = true;
            this.lbPayInvoiceID.Location = new System.Drawing.Point(467, 79);
            this.lbPayInvoiceID.Name = "lbPayInvoiceID";
            this.lbPayInvoiceID.Size = new System.Drawing.Size(69, 12);
            this.lbPayInvoiceID.TabIndex = 34;
            this.lbPayInvoiceID.Text = "PayInvoiceID";
            // 
            // lbPreviewNo
            // 
            this.lbPreviewNo.AutoSize = true;
            this.lbPreviewNo.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPreviewNo.Location = new System.Drawing.Point(72, 61);
            this.lbPreviewNo.Name = "lbPreviewNo";
            this.lbPreviewNo.Size = new System.Drawing.Size(56, 12);
            this.lbPreviewNo.TabIndex = 35;
            this.lbPreviewNo.Text = "PreviewNo";
            // 
            // lbPayee
            // 
            this.lbPayee.AutoSize = true;
            this.lbPayee.Location = new System.Drawing.Point(235, 61);
            this.lbPayee.Name = "lbPayee";
            this.lbPayee.Size = new System.Drawing.Size(32, 12);
            this.lbPayee.TabIndex = 37;
            this.lbPayee.Text = "Payee";
            // 
            // lbPayTo
            // 
            this.lbPayTo.AutoSize = true;
            this.lbPayTo.Location = new System.Drawing.Point(380, 61);
            this.lbPayTo.Name = "lbPayTo";
            this.lbPayTo.Size = new System.Drawing.Size(31, 12);
            this.lbPayTo.TabIndex = 37;
            this.lbPayTo.Text = "Payto";
            // 
            // lbPayToCode
            // 
            this.lbPayToCode.AutoSize = true;
            this.lbPayToCode.Location = new System.Drawing.Point(540, 61);
            this.lbPayToCode.Name = "lbPayToCode";
            this.lbPayToCode.Size = new System.Drawing.Size(60, 12);
            this.lbPayToCode.TabIndex = 37;
            this.lbPayToCode.Text = "PayToCode";
            // 
            // lbCNCY
            // 
            this.lbCNCY.AutoSize = true;
            this.lbCNCY.Location = new System.Drawing.Point(235, 79);
            this.lbCNCY.Name = "lbCNCY";
            this.lbCNCY.Size = new System.Drawing.Size(49, 12);
            this.lbCNCY.TabIndex = 37;
            this.lbCNCY.Text = "Currency";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(72, 79);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(26, 12);
            this.lbCost.TabIndex = 37;
            this.lbCost.Text = "Cost";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(379, 79);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(56, 12);
            this.lbCreateDate.TabIndex = 37;
            this.lbCreateDate.Text = "CreateDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "大發票#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "付款人:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "收款人:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "收款人代碼:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "金額:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "幣別:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "發票日期:";
            // 
            // AdjustAPAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 771);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbCNCY);
            this.Controls.Add(this.lbPayToCode);
            this.Controls.Add(this.lbPayTo);
            this.Controls.Add(this.lbPayee);
            this.Controls.Add(this.lbPreviewNo);
            this.Controls.Add(this.lbPayInvoiceID);
            this.Controls.Add(this.btnKFUpdate);
            this.Controls.Add(this.ddlParType);
            this.Controls.Add(this.ddlTransType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtItemValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdjustAPAmount";
            this.Text = "AP大發票金額調整(AdjustAPAmount)";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentInvNoHeader)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBLNoHeader)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCostByShipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvPaymentInvNoHeader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvBLNoHeader;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gvCostByShipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtItemValue;
        private System.Windows.Forms.Button btnKFUpdate;
        private System.Windows.Forms.ComboBox ddlParType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlTransType;
        private System.Windows.Forms.Label lbPayInvoiceID;
        private System.Windows.Forms.Label lbPreviewNo;
        private System.Windows.Forms.Label lbPayee;
        private System.Windows.Forms.Label lbPayTo;
        private System.Windows.Forms.Label lbPayToCode;
        private System.Windows.Forms.Label lbCNCY;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}