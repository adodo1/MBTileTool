namespace MBTileTool
{
    partial class RewardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RewardForm));
            this.groupBoxBG = new System.Windows.Forms.GroupBox();
            this.pictureBoxZFB = new System.Windows.Forms.PictureBox();
            this.pictureBoxWX = new System.Windows.Forms.PictureBox();
            this.groupBoxBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBG
            // 
            this.groupBoxBG.Controls.Add(this.pictureBoxZFB);
            this.groupBoxBG.Controls.Add(this.pictureBoxWX);
            this.groupBoxBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBG.Name = "groupBoxBG";
            this.groupBoxBG.Size = new System.Drawing.Size(478, 235);
            this.groupBoxBG.TabIndex = 0;
            this.groupBoxBG.TabStop = false;
            // 
            // pictureBoxZFB
            // 
            this.pictureBoxZFB.Location = new System.Drawing.Point(261, 20);
            this.pictureBoxZFB.Name = "pictureBoxZFB";
            this.pictureBoxZFB.Size = new System.Drawing.Size(202, 202);
            this.pictureBoxZFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZFB.TabIndex = 0;
            this.pictureBoxZFB.TabStop = false;
            // 
            // pictureBoxWX
            // 
            this.pictureBoxWX.Location = new System.Drawing.Point(12, 20);
            this.pictureBoxWX.Name = "pictureBoxWX";
            this.pictureBoxWX.Size = new System.Drawing.Size(202, 202);
            this.pictureBoxWX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWX.TabIndex = 0;
            this.pictureBoxWX.TabStop = false;
            // 
            // RewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 235);
            this.Controls.Add(this.groupBoxBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RewardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "感谢使用ヾ(๑╹◡╹)ﾉ\"";
            this.groupBoxBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBG;
        private System.Windows.Forms.PictureBox pictureBoxZFB;
        private System.Windows.Forms.PictureBox pictureBoxWX;
    }
}