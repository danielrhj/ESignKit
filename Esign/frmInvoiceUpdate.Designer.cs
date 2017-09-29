namespace CostErrDeal.KFErr
{
    partial class frmInvoiceUpdate
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtUpLoadfile = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.GroupBox();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblOK = new System.Windows.Forms.Label();
            this.txtCoding = new System.Windows.Forms.TextBox();
            this.btnExecCode = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtUpLoadfile
            // 
            this.txtUpLoadfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpLoadfile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpLoadfile.Location = new System.Drawing.Point(113, 20);
            this.txtUpLoadfile.Name = "txtUpLoadfile";
            this.txtUpLoadfile.Size = new System.Drawing.Size(255, 23);
            this.txtUpLoadfile.TabIndex = 1;
            // 
            // x
            // 
            this.x.Controls.Add(this.btnUpLoad);
            this.x.Controls.Add(this.btnOpen);
            this.x.Controls.Add(this.label1);
            this.x.Controls.Add(this.txtUpLoadfile);
            this.x.Location = new System.Drawing.Point(20, 46);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(650, 63);
            this.x.TabIndex = 2;
            this.x.TabStop = false;
            this.x.Text = "文件上载";
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpLoad.Location = new System.Drawing.Point(468, 20);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(62, 25);
            this.btnUpLoad.TabIndex = 11;
            this.btnUpLoad.Text = "上 传";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(373, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(62, 25);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "浏 览";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择文件:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(516, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 28);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "发票更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(243, 356);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOK.ForeColor = System.Drawing.Color.Green;
            this.lblOK.Location = new System.Drawing.Point(33, 509);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(0, 21);
            this.lblOK.TabIndex = 6;
            // 
            // txtCoding
            // 
            this.txtCoding.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoding.Location = new System.Drawing.Point(279, 134);
            this.txtCoding.Multiline = true;
            this.txtCoding.Name = "txtCoding";
            this.txtCoding.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCoding.Size = new System.Drawing.Size(391, 356);
            this.txtCoding.TabIndex = 8;
            // 
            // btnExecCode
            // 
            this.btnExecCode.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExecCode.Location = new System.Drawing.Point(352, 509);
            this.btnExecCode.Name = "btnExecCode";
            this.btnExecCode.Size = new System.Drawing.Size(73, 28);
            this.btnExecCode.TabIndex = 10;
            this.btnExecCode.Text = "自助代码";
            this.btnExecCode.UseVisualStyleBackColor = true;
            this.btnExecCode.Click += new System.EventHandler(this.btnExecCode_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(22, 112);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(92, 17);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "待更新发票列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(234, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "虚拟发票更新正式发票";
            // 
            // frmInvoiceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnExecCode);
            this.Controls.Add(this.txtCoding);
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.x);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmInvoiceUpdate";
            this.Text = "GetEsignStatusInfo";
            this.x.ResumeLayout(false);
            this.x.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtUpLoadfile;
        private System.Windows.Forms.GroupBox x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.TextBox txtCoding;
        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.Button btnExecCode;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
    }
}