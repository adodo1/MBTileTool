namespace MBTileTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelReward = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.toolStripnPack = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonMore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClearn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPack = new System.Windows.Forms.ToolStripButton();
            this.toolStripnExtract = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOutPath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFileExt = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxExt = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExtract = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripInfo.SuspendLayout();
            this.toolStripnPack.SuspendLayout();
            this.toolStripnExtract.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelReward});
            this.statusStripInfo.Location = new System.Drawing.Point(0, 296);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(455, 22);
            this.statusStripInfo.TabIndex = 0;
            this.statusStripInfo.Text = "状态栏";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabelStatus.Text = "就绪";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(317, 17);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel2.Text = "『=DoDo=』";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelReward
            // 
            this.toolStripStatusLabelReward.IsLink = true;
            this.toolStripStatusLabelReward.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusLabelReward.Name = "toolStripStatusLabelReward";
            this.toolStripStatusLabelReward.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabelReward.Text = "打赏";
            this.toolStripStatusLabelReward.Click += new System.EventHandler(this.toolStripStatusLabelReward_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 12;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 50);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFiles.Size = new System.Drawing.Size(455, 246);
            this.listBoxFiles.TabIndex = 3;
            // 
            // toolStripnPack
            // 
            this.toolStripnPack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMore,
            this.toolStripSeparator1,
            this.toolStripButtonAdd,
            this.toolStripSeparator2,
            this.toolStripButtonDel,
            this.toolStripSeparator3,
            this.toolStripButtonClearn,
            this.toolStripSeparator4,
            this.toolStripButtonPack});
            this.toolStripnPack.Location = new System.Drawing.Point(0, 0);
            this.toolStripnPack.Name = "toolStripnPack";
            this.toolStripnPack.Size = new System.Drawing.Size(455, 25);
            this.toolStripnPack.TabIndex = 3;
            this.toolStripnPack.Text = "打包工具";
            // 
            // toolStripButtonMore
            // 
            this.toolStripButtonMore.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMore.Image")));
            this.toolStripButtonMore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMore.Name = "toolStripButtonMore";
            this.toolStripButtonMore.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonMore.Text = "添加路径";
            this.toolStripButtonMore.Click += new System.EventHandler(this.toolStripButtonMore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonAdd.Text = "添加文件";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDel.Image")));
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonDel.Text = "删除";
            this.toolStripButtonDel.Click += new System.EventHandler(this.toolStripButtonDel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonClearn
            // 
            this.toolStripButtonClearn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearn.Image")));
            this.toolStripButtonClearn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearn.Name = "toolStripButtonClearn";
            this.toolStripButtonClearn.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonClearn.Text = "清空";
            this.toolStripButtonClearn.Click += new System.EventHandler(this.toolStripButtonClearn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPack
            // 
            this.toolStripButtonPack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPack.Image")));
            this.toolStripButtonPack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPack.Name = "toolStripButtonPack";
            this.toolStripButtonPack.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonPack.Text = "打包";
            this.toolStripButtonPack.Click += new System.EventHandler(this.toolStripButtonPack_Click);
            // 
            // toolStripnExtract
            // 
            this.toolStripnExtract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOutPath,
            this.toolStripSeparator6,
            this.toolStripButtonFileExt,
            this.toolStripComboBoxExt,
            this.toolStripSeparator7,
            this.toolStripButtonExtract});
            this.toolStripnExtract.Location = new System.Drawing.Point(0, 25);
            this.toolStripnExtract.Name = "toolStripnExtract";
            this.toolStripnExtract.Size = new System.Drawing.Size(455, 25);
            this.toolStripnExtract.TabIndex = 4;
            this.toolStripnExtract.Text = "提取工具";
            // 
            // toolStripButtonOutPath
            // 
            this.toolStripButtonOutPath.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOutPath.Image")));
            this.toolStripButtonOutPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutPath.Name = "toolStripButtonOutPath";
            this.toolStripButtonOutPath.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonOutPath.Text = "输出路径";
            this.toolStripButtonOutPath.Click += new System.EventHandler(this.toolStripButtonOutPath_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFileExt
            // 
            this.toolStripButtonFileExt.Enabled = false;
            this.toolStripButtonFileExt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileExt.Image")));
            this.toolStripButtonFileExt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileExt.Name = "toolStripButtonFileExt";
            this.toolStripButtonFileExt.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonFileExt.Text = "文件扩展";
            // 
            // toolStripComboBoxExt
            // 
            this.toolStripComboBoxExt.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "PBF"});
            this.toolStripComboBoxExt.Name = "toolStripComboBoxExt";
            this.toolStripComboBoxExt.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExtract
            // 
            this.toolStripButtonExtract.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExtract.Image")));
            this.toolStripButtonExtract.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExtract.Name = "toolStripButtonExtract";
            this.toolStripButtonExtract.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonExtract.Text = "提取";
            this.toolStripButtonExtract.Click += new System.EventHandler(this.toolStripButtonExtract_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 318);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.toolStripnExtract);
            this.Controls.Add(this.toolStripnPack);
            this.Controls.Add(this.statusStripInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "瓦片工具 v1.0";
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.toolStripnPack.ResumeLayout(false);
            this.toolStripnPack.PerformLayout();
            this.toolStripnExtract.ResumeLayout(false);
            this.toolStripnExtract.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelReward;
        private System.Windows.Forms.ToolStrip toolStripnPack;
        private System.Windows.Forms.ToolStripButton toolStripButtonMore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonPack;
        private System.Windows.Forms.ToolStrip toolStripnExtract;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxExt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonExtract;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileExt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}

