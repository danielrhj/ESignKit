namespace CostErrDeal.Esign
{
    partial class SendEalAccount
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEalNo = new System.Windows.Forms.TextBox();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.btnDelEal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.btnEPTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 48);
            this.label3.TabIndex = 21;
            this.label3.Text = "預結報拋轉";
            // 
            // btnSendTo
            // 
            this.btnSendTo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendTo.Location = new System.Drawing.Point(377, 108);
            this.btnSendTo.Name = "btnSendTo";
            this.btnSendTo.Size = new System.Drawing.Size(78, 28);
            this.btnSendTo.TabIndex = 26;
            this.btnSendTo.Text = "拋 轉";
            this.btnSendTo.UseVisualStyleBackColor = true;
            this.btnSendTo.Click += new System.EventHandler(this.btnSendTo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(117, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "預結單號:";
            // 
            // txtEalNo
            // 
            this.txtEalNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEalNo.Location = new System.Drawing.Point(202, 70);
            this.txtEalNo.Name = "txtEalNo";
            this.txtEalNo.Size = new System.Drawing.Size(253, 27);
            this.txtEalNo.TabIndex = 24;
            // 
            // lblMsg1
            // 
            this.lblMsg1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg1.ForeColor = System.Drawing.Color.Red;
            this.lblMsg1.Location = new System.Drawing.Point(26, 228);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(690, 274);
            this.lblMsg1.TabIndex = 27;
            this.lblMsg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelEal
            // 
            this.btnDelEal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelEal.Location = new System.Drawing.Point(266, 108);
            this.btnDelEal.Name = "btnDelEal";
            this.btnDelEal.Size = new System.Drawing.Size(78, 28);
            this.btnDelEal.TabIndex = 29;
            this.btnDelEal.Text = "刪 除";
            this.btnDelEal.UseVisualStyleBackColor = true;
            this.btnDelEal.Click += new System.EventHandler(this.btnDelEal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(117, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "法人:";
            // 
            // btnTestConn
            // 
            this.btnTestConn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTestConn.Location = new System.Drawing.Point(377, 161);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(85, 28);
            this.btnTestConn.TabIndex = 32;
            this.btnTestConn.Text = "測試連接";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // btnEPTest
            // 
            this.btnEPTest.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEPTest.Location = new System.Drawing.Point(377, 217);
            this.btnEPTest.Name = "btnEPTest";
            this.btnEPTest.Size = new System.Drawing.Size(85, 28);
            this.btnEPTest.TabIndex = 33;
            this.btnEPTest.Text = "測試EPPlus";
            this.btnEPTest.UseVisualStyleBackColor = true;
            this.btnEPTest.Click += new System.EventHandler(this.btnEPTest_Click);
            // 
            // SendEalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 521);
            this.Controls.Add(this.btnEPTest);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelEal);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.btnSendTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEalNo);
            this.Controls.Add(this.label3);
            this.Name = "SendEalAccount";
            this.Text = "SendEalAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEalNo;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Button btnDelEal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Button btnEPTest;
    }
}