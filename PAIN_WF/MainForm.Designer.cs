
namespace PAIN_WF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.newWindowToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 589);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(926, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "mainStatusStrip";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(926, 38);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // newWindowToolStripButton
            // 
            this.newWindowToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newWindowToolStripButton.Image")));
            this.newWindowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newWindowToolStripButton.Name = "newWindowToolStripButton";
            this.newWindowToolStripButton.Size = new System.Drawing.Size(80, 35);
            this.newWindowToolStripButton.Text = "New window";
            this.newWindowToolStripButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.newWindowToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newWindowToolStripButton.ToolTipText = "New";
            this.newWindowToolStripButton.Click += new System.EventHandler(this.newWindowButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(926, 24);
            this.mainMenuStrip.TabIndex = 3;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newWindowToolStripMenuItem.Text = "New window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 611);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton newWindowToolStripButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        public System.Windows.Forms.StatusStrip mainStatusStrip;
        public System.Windows.Forms.ToolStrip mainToolStrip;
    }
}

