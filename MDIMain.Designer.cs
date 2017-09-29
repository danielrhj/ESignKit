namespace CostErrDeal
{
    partial class MDIMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.KFErrDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.EsignSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.KFInvoiceCostChange = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActorInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.EsignActor = new System.Windows.Forms.ToolStripMenuItem();
            this.GetInvoiceData = new System.Windows.Forms.ToolStripMenuItem();
            this.AttachCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.eInvoiceCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.Test = new System.Windows.Forms.ToolStripMenuItem();
            this.EsignCostChange = new System.Windows.Forms.ToolStripMenuItem();
            this.NewInvoiceChange = new System.Windows.Forms.ToolStripMenuItem();
            this.EalSendToSAP = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KFEsignDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.KFEsignPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.在線更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.費用異常處理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdjustAPAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.特殊功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TiptopInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.DBInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 720);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1156, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // KFErrDeal
            // 
            this.KFErrDeal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EsignSearch,
            this.KFInvoiceCostChange,
            this.btnActorInfo,
            this.EsignActor,
            this.GetInvoiceData,
            this.AttachCmd,
            this.eInvoiceCmd,
            this.Test,
            this.EsignCostChange,
            this.NewInvoiceChange,
            this.EalSendToSAP});
            this.KFErrDeal.Name = "KFErrDeal";
            this.KFErrDeal.Size = new System.Drawing.Size(92, 21);
            this.KFErrDeal.Text = "科法異常處理";
            // 
            // EsignSearch
            // 
            this.EsignSearch.Name = "EsignSearch";
            this.EsignSearch.Size = new System.Drawing.Size(160, 22);
            this.EsignSearch.Text = "签核狀態查询";
            this.EsignSearch.Click += new System.EventHandler(this.EsignSearch_Click);
            // 
            // KFInvoiceCostChange
            // 
            this.KFInvoiceCostChange.Name = "KFInvoiceCostChange";
            this.KFInvoiceCostChange.Size = new System.Drawing.Size(160, 22);
            this.KFInvoiceCostChange.Text = "發票明細查詢";
            this.KFInvoiceCostChange.Click += new System.EventHandler(this.KFInvoiceCostChange_Click);
            // 
            // btnActorInfo
            // 
            this.btnActorInfo.Name = "btnActorInfo";
            this.btnActorInfo.Size = new System.Drawing.Size(160, 22);
            this.btnActorInfo.Text = "用戶信息查询";
            this.btnActorInfo.Click += new System.EventHandler(this.btnActorInfo_Click);
            // 
            // EsignActor
            // 
            this.EsignActor.Name = "EsignActor";
            this.EsignActor.Size = new System.Drawing.Size(160, 22);
            this.EsignActor.Text = "变更当前签核人";
            this.EsignActor.Click += new System.EventHandler(this.EsignActor_Click);
            // 
            // GetInvoiceData
            // 
            this.GetInvoiceData.Name = "GetInvoiceData";
            this.GetInvoiceData.Size = new System.Drawing.Size(160, 22);
            this.GetInvoiceData.Text = "簽核路徑維護";
            this.GetInvoiceData.Click += new System.EventHandler(this.GetSignPath_Click);
            // 
            // AttachCmd
            // 
            this.AttachCmd.Name = "AttachCmd";
            this.AttachCmd.Size = new System.Drawing.Size(160, 22);
            this.AttachCmd.Text = "签核附件更新";
            this.AttachCmd.Visible = false;
            this.AttachCmd.Click += new System.EventHandler(this.AttachCmd_Click);
            // 
            // eInvoiceCmd
            // 
            this.eInvoiceCmd.Name = "eInvoiceCmd";
            this.eInvoiceCmd.Size = new System.Drawing.Size(160, 22);
            this.eInvoiceCmd.Text = "子系统重抛";
            this.eInvoiceCmd.Click += new System.EventHandler(this.eInvoiceCmd_Click);
            // 
            // Test
            // 
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(160, 22);
            this.Test.Text = "預結報來源查詢";
            this.Test.Click += new System.EventHandler(this.CheckAccountSource_Click);
            // 
            // EsignCostChange
            // 
            this.EsignCostChange.Name = "EsignCostChange";
            this.EsignCostChange.Size = new System.Drawing.Size(160, 22);
            this.EsignCostChange.Text = "送簽代碼更新";
            this.EsignCostChange.Click += new System.EventHandler(this.EsignCostChange_Click);
            // 
            // NewInvoiceChange
            // 
            this.NewInvoiceChange.Name = "NewInvoiceChange";
            this.NewInvoiceChange.Size = new System.Drawing.Size(160, 22);
            this.NewInvoiceChange.Text = "虛擬發票替換";
            this.NewInvoiceChange.Click += new System.EventHandler(this.NewInvoiceChange_Click);
            // 
            // EalSendToSAP
            // 
            this.EalSendToSAP.Name = "EalSendToSAP";
            this.EalSendToSAP.Size = new System.Drawing.Size(160, 22);
            this.EalSendToSAP.Text = "預結報拋轉";
            this.EalSendToSAP.Click += new System.EventHandler(this.EalSendToSAP_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem,
            this.KFEsignDoc,
            this.KFEsignPicture,
            this.在線更新ToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(61, 21);
            this.helpMenu.Text = "帮助(&H)";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.contentsToolStripMenuItem.Text = "目录(&C)";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.indexToolStripMenuItem.Text = "索引(&I)";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.searchToolStripMenuItem.Text = "搜索(&S)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(163, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "关于(&A) ... ...";
            // 
            // KFEsignDoc
            // 
            this.KFEsignDoc.Name = "KFEsignDoc";
            this.KFEsignDoc.Size = new System.Drawing.Size(166, 22);
            this.KFEsignDoc.Text = "科法签核文档";
            this.KFEsignDoc.Click += new System.EventHandler(this.KFEsignDoc_Click);
            // 
            // KFEsignPicture
            // 
            this.KFEsignPicture.Name = "KFEsignPicture";
            this.KFEsignPicture.Size = new System.Drawing.Size(166, 22);
            this.KFEsignPicture.Text = "科法流程图";
            this.KFEsignPicture.Click += new System.EventHandler(this.KFEsignPicture_Click);
            // 
            // 在線更新ToolStripMenuItem
            // 
            this.在線更新ToolStripMenuItem.Name = "在線更新ToolStripMenuItem";
            this.在線更新ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.在線更新ToolStripMenuItem.Text = "在線更新";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KFErrDeal,
            this.費用異常處理ToolStripMenuItem,
            this.特殊功能ToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Margin = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1156, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // 費用異常處理ToolStripMenuItem
            // 
            this.費用異常處理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdjustAPAmount});
            this.費用異常處理ToolStripMenuItem.Name = "費用異常處理ToolStripMenuItem";
            this.費用異常處理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.費用異常處理ToolStripMenuItem.Text = "費用異常處理";
            // 
            // AdjustAPAmount
            // 
            this.AdjustAPAmount.Name = "AdjustAPAmount";
            this.AdjustAPAmount.Size = new System.Drawing.Size(151, 22);
            this.AdjustAPAmount.Text = "AP大發票調整";
            this.AdjustAPAmount.Click += new System.EventHandler(this.AdjustAPAmount_Click);
            // 
            // 特殊功能ToolStripMenuItem
            // 
            this.特殊功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TiptopInfo,
            this.DBInfo});
            this.特殊功能ToolStripMenuItem.Name = "特殊功能ToolStripMenuItem";
            this.特殊功能ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.特殊功能ToolStripMenuItem.Text = "特殊功能";
            // 
            // TiptopInfo
            // 
            this.TiptopInfo.Name = "TiptopInfo";
            this.TiptopInfo.Size = new System.Drawing.Size(152, 22);
            this.TiptopInfo.Text = "預結報連接";
            this.TiptopInfo.Click += new System.EventHandler(this.TiptopInfo_Click);
            // 
            // DBInfo
            // 
            this.DBInfo.Name = "DBInfo";
            this.DBInfo.Size = new System.Drawing.Size(152, 22);
            this.DBInfo.Text = "DB連接";
            this.DBInfo.Click += new System.EventHandler(this.DBInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(513, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "當前用戶:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(578, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 14);
            this.lblUserName.TabIndex = 5;
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(1156, 742);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMain";
            this.Text = "MDIMain";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem KFErrDeal;
        private System.Windows.Forms.ToolStripMenuItem EsignSearch;
        private System.Windows.Forms.ToolStripMenuItem btnActorInfo;
        private System.Windows.Forms.ToolStripMenuItem AttachCmd;
        private System.Windows.Forms.ToolStripMenuItem EsignActor;
        private System.Windows.Forms.ToolStripMenuItem eInvoiceCmd;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KFEsignDoc;
        private System.Windows.Forms.ToolStripMenuItem KFEsignPicture;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 在線更新ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripMenuItem 費用異常處理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetInvoiceData;
        private System.Windows.Forms.ToolStripMenuItem KFInvoiceCostChange;
        private System.Windows.Forms.ToolStripMenuItem Test;
        private System.Windows.Forms.ToolStripMenuItem EsignCostChange;
        private System.Windows.Forms.ToolStripMenuItem NewInvoiceChange;
        private System.Windows.Forms.ToolStripMenuItem EalSendToSAP;
        private System.Windows.Forms.ToolStripMenuItem AdjustAPAmount;
        private System.Windows.Forms.ToolStripMenuItem 特殊功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TiptopInfo;
        private System.Windows.Forms.ToolStripMenuItem DBInfo;
    }
}



