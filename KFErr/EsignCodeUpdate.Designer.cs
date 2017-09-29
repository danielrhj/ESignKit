namespace CostErrDeal.KFErr
{
    partial class EsignCodeUpdate
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
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreviewNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.ddlUpdateType = new System.Windows.Forms.ComboBox();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldCode = new System.Windows.Forms.TextBox();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnExcelUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(230, 70);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(145, 27);
            this.txtInvoiceNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(145, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "发票号码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(387, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "大发票号码:";
            // 
            // txtPreviewNo
            // 
            this.txtPreviewNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviewNo.Location = new System.Drawing.Point(487, 70);
            this.txtPreviewNo.Name = "txtPreviewNo";
            this.txtPreviewNo.Size = new System.Drawing.Size(150, 27);
            this.txtPreviewNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(249, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "发票送签代码更新";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(668, 68);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 28);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(783, 376);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrderNo.Location = new System.Drawing.Point(460, 516);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(129, 26);
            this.txtOrderNo.TabIndex = 7;
            // 
            // ddlUpdateType
            // 
            this.ddlUpdateType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlUpdateType.FormattingEnabled = true;
            this.ddlUpdateType.Items.AddRange(new object[] {
            "法人更新",
            "厂商代码更新",
            "科目代码更新",
            "费用代码更新"});
            this.ddlUpdateType.Location = new System.Drawing.Point(14, 512);
            this.ddlUpdateType.Name = "ddlUpdateType";
            this.ddlUpdateType.Size = new System.Drawing.Size(259, 30);
            this.ddlUpdateType.TabIndex = 8;
            // 
            // btnUpDate
            // 
            this.btnUpDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpDate.Location = new System.Drawing.Point(603, 514);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(84, 28);
            this.btnUpDate.TabIndex = 9;
            this.btnUpDate.Text = "少量更新";
            this.btnUpDate.UseVisualStyleBackColor = true;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "替換為:";
            // 
            // txtOldCode
            // 
            this.txtOldCode.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldCode.Location = new System.Drawing.Point(285, 514);
            this.txtOldCode.Name = "txtOldCode";
            this.txtOldCode.Size = new System.Drawing.Size(119, 26);
            this.txtOldCode.TabIndex = 11;
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkTax.Location = new System.Drawing.Point(53, 77);
            this.chkTax.Name = "chkTax";
            this.chkTax.Size = new System.Drawing.Size(76, 16);
            this.chkTax.TabIndex = 12;
            this.chkTax.Text = "稅別更新";
            this.chkTax.UseVisualStyleBackColor = true;
            this.chkTax.CheckedChanged += new System.EventHandler(this.chkTax_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(362, 544);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(137, 12);
            this.lblMsg.TabIndex = 13;
            this.lblMsg.Text = "按費用項目替換(可為空)";
            this.lblMsg.Visible = false;
            // 
            // btnExcelUpdate
            // 
            this.btnExcelUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExcelUpdate.Location = new System.Drawing.Point(711, 514);
            this.btnExcelUpdate.Name = "btnExcelUpdate";
            this.btnExcelUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnExcelUpdate.TabIndex = 14;
            this.btnExcelUpdate.Text = "批量更新";
            this.btnExcelUpdate.UseVisualStyleBackColor = true;
            this.btnExcelUpdate.Click += new System.EventHandler(this.btnExcelUpdate_Click);
            // 
            // EsignCodeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 583);
            this.Controls.Add(this.btnExcelUpdate);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.chkTax);
            this.Controls.Add(this.txtOldCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpDate);
            this.Controls.Add(this.ddlUpdateType);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreviewNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EsignCodeUpdate";
            this.Text = "发票送签代码更新";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreviewNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.ComboBox ddlUpdateType;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldCode;
        private System.Windows.Forms.CheckBox chkTax;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnExcelUpdate;
    }
}