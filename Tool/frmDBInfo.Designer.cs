namespace CostErrDeal.Tool
{
    partial class frmDBInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConn = new System.Windows.Forms.TextBox();
            this.ead01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ead02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ead03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ead04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ead06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ead05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ead01,
            this.ead02,
            this.ead03,
            this.ead04,
            this.ead06,
            this.ead05});
            this.dataGridView1.Location = new System.Drawing.Point(10, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 353);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(47, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "法人查詢";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1140, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "Connection:";
            // 
            // txtConn
            // 
            this.txtConn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConn.Location = new System.Drawing.Point(101, 444);
            this.txtConn.Multiline = true;
            this.txtConn.Name = "txtConn";
            this.txtConn.Size = new System.Drawing.Size(873, 78);
            this.txtConn.TabIndex = 36;
            // 
            // ead01
            // 
            this.ead01.DataPropertyName = "ead01";
            this.ead01.HeaderText = "ead01";
            this.ead01.Name = "ead01";
            this.ead01.Width = 60;
            // 
            // ead02
            // 
            this.ead02.DataPropertyName = "ead02";
            this.ead02.HeaderText = "ead02";
            this.ead02.Name = "ead02";
            this.ead02.Width = 300;
            // 
            // ead03
            // 
            this.ead03.DataPropertyName = "ead03";
            this.ead03.HeaderText = "ead03";
            this.ead03.Name = "ead03";
            this.ead03.Width = 80;
            // 
            // ead04
            // 
            this.ead04.DataPropertyName = "ead04";
            this.ead04.HeaderText = "ead04";
            this.ead04.Name = "ead04";
            this.ead04.Width = 300;
            // 
            // ead06
            // 
            this.ead06.DataPropertyName = "ead06";
            this.ead06.HeaderText = "ead06";
            this.ead06.Name = "ead06";
            this.ead06.Width = 150;
            // 
            // ead05
            // 
            this.ead05.DataPropertyName = "ead05";
            this.ead05.HeaderText = "ead05";
            this.ead05.Name = "ead05";
            this.ead05.Width = 50;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(481, 24);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(100, 21);
            this.txtQuery.TabIndex = 37;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(435, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "法人";
            // 
            // frmDBInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtConn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDBInfo";
            this.Text = "frmTiptopInfo";
            this.Load += new System.EventHandler(this.frmDBInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ead01;
        private System.Windows.Forms.DataGridViewTextBoxColumn ead02;
        private System.Windows.Forms.DataGridViewTextBoxColumn ead03;
        private System.Windows.Forms.DataGridViewTextBoxColumn ead04;
        private System.Windows.Forms.DataGridViewTextBoxColumn ead06;
        private System.Windows.Forms.DataGridViewTextBoxColumn ead05;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label2;
    }
}