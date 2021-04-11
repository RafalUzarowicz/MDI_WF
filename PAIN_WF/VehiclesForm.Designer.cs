
namespace PAIN_WF
{
    partial class VehiclesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesForm));
            this.viewToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.viewStatusStrip = new System.Windows.Forms.StatusStrip();
            this.vehicleCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewListView = new System.Windows.Forms.ListView();
            this.brandColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxSpeedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productionDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.filterToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.viewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.viewToolStripContainer.ContentPanel.SuspendLayout();
            this.viewToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.viewToolStripContainer.SuspendLayout();
            this.viewStatusStrip.SuspendLayout();
            this.viewMenuStrip.SuspendLayout();
            this.viewToolStrip.SuspendLayout();
            this.viewContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewToolStripContainer
            // 
            // 
            // viewToolStripContainer.BottomToolStripPanel
            // 
            this.viewToolStripContainer.BottomToolStripPanel.Controls.Add(this.viewStatusStrip);
            // 
            // viewToolStripContainer.ContentPanel
            // 
            this.viewToolStripContainer.ContentPanel.Controls.Add(this.viewListView);
            this.viewToolStripContainer.ContentPanel.Size = new System.Drawing.Size(480, 290);
            this.viewToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.viewToolStripContainer.Name = "viewToolStripContainer";
            this.viewToolStripContainer.Size = new System.Drawing.Size(480, 290);
            this.viewToolStripContainer.TabIndex = 0;
            this.viewToolStripContainer.Text = "toolStripContainer1";
            // 
            // viewToolStripContainer.TopToolStripPanel
            // 
            this.viewToolStripContainer.TopToolStripPanel.Controls.Add(this.viewMenuStrip);
            this.viewToolStripContainer.TopToolStripPanel.Controls.Add(this.viewToolStrip);
            // 
            // viewStatusStrip
            // 
            this.viewStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.viewStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleCountToolStripStatusLabel});
            this.viewStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.viewStatusStrip.Name = "viewStatusStrip";
            this.viewStatusStrip.Size = new System.Drawing.Size(30, 22);
            this.viewStatusStrip.TabIndex = 0;
            this.viewStatusStrip.Visible = false;
            // 
            // vehicleCountToolStripStatusLabel
            // 
            this.vehicleCountToolStripStatusLabel.Name = "vehicleCountToolStripStatusLabel";
            this.vehicleCountToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.vehicleCountToolStripStatusLabel.Text = "0";
            // 
            // viewListView
            // 
            this.viewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brandColumnHeader,
            this.maxSpeedColumnHeader,
            this.productionDateColumnHeader,
            this.typeColumnHeader});
            this.viewListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewListView.HideSelection = false;
            this.viewListView.Location = new System.Drawing.Point(0, 0);
            this.viewListView.Name = "viewListView";
            this.viewListView.Size = new System.Drawing.Size(480, 290);
            this.viewListView.TabIndex = 0;
            this.viewListView.UseCompatibleStateImageBehavior = false;
            this.viewListView.View = System.Windows.Forms.View.Details;
            this.viewListView.SelectedIndexChanged += new System.EventHandler(this.viewListView_SelectedIndexChanged);
            // 
            // brandColumnHeader
            // 
            this.brandColumnHeader.Text = "Brand";
            this.brandColumnHeader.Width = 84;
            // 
            // maxSpeedColumnHeader
            // 
            this.maxSpeedColumnHeader.Text = "Max speed";
            this.maxSpeedColumnHeader.Width = 123;
            // 
            // productionDateColumnHeader
            // 
            this.productionDateColumnHeader.Text = "Production date";
            this.productionDateColumnHeader.Width = 115;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.Width = 106;
            // 
            // viewMenuStrip
            // 
            this.viewMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.viewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.editMenuItem,
            this.removeMenuItem});
            this.viewMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.viewMenuStrip.Name = "viewMenuStrip";
            this.viewMenuStrip.Size = new System.Drawing.Size(480, 24);
            this.viewMenuStrip.TabIndex = 1;
            this.viewMenuStrip.Text = "menuStrip1";
            this.viewMenuStrip.Visible = false;
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            this.editMenuItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeMenuItem.Text = "Remove";
            this.removeMenuItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // viewToolStrip
            // 
            this.viewToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.viewToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.removeToolStripButton,
            this.filterToolStripComboBox});
            this.viewToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.viewToolStrip.Location = new System.Drawing.Point(3, 0);
            this.viewToolStrip.Name = "viewToolStrip";
            this.viewToolStrip.Size = new System.Drawing.Size(284, 38);
            this.viewToolStrip.TabIndex = 0;
            this.viewToolStrip.Visible = false;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(33, 35);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addToolStripButton.Click += new System.EventHandler(this.addItem_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(31, 35);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editToolStripButton.Click += new System.EventHandler(this.editItem_Click);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripButton.Image")));
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(54, 35);
            this.removeToolStripButton.Text = "Remove";
            this.removeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeToolStripButton.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // filterToolStripComboBox
            // 
            this.filterToolStripComboBox.Items.AddRange(new object[] {
            "None",
            "<100 km/h",
            ">= 100 km/h"});
            this.filterToolStripComboBox.Name = "filterToolStripComboBox";
            this.filterToolStripComboBox.Size = new System.Drawing.Size(121, 38);
            this.filterToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.filterToolStripComboBox_SelectedIndexChanged);
            // 
            // viewContextMenuStrip
            // 
            this.viewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.viewContextMenuStrip.Name = "viewContextMenuStrip";
            this.viewContextMenuStrip.Size = new System.Drawing.Size(118, 70);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 290);
            this.ContextMenuStrip = this.viewContextMenuStrip;
            this.Controls.Add(this.viewToolStripContainer);
            this.MainMenuStrip = this.viewMenuStrip;
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.Activated += new System.EventHandler(this.VehiclesForm_Activated);
            this.Deactivate += new System.EventHandler(this.VehiclesForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehiclesForm_FormClosing);
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            this.viewToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.viewToolStripContainer.BottomToolStripPanel.PerformLayout();
            this.viewToolStripContainer.ContentPanel.ResumeLayout(false);
            this.viewToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.viewToolStripContainer.TopToolStripPanel.PerformLayout();
            this.viewToolStripContainer.ResumeLayout(false);
            this.viewToolStripContainer.PerformLayout();
            this.viewStatusStrip.ResumeLayout(false);
            this.viewStatusStrip.PerformLayout();
            this.viewMenuStrip.ResumeLayout(false);
            this.viewMenuStrip.PerformLayout();
            this.viewToolStrip.ResumeLayout(false);
            this.viewToolStrip.PerformLayout();
            this.viewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer viewToolStripContainer;
        private System.Windows.Forms.StatusStrip viewStatusStrip;
        private System.Windows.Forms.ListView viewListView;
        private System.Windows.Forms.ColumnHeader brandColumnHeader;
        private System.Windows.Forms.ColumnHeader maxSpeedColumnHeader;
        private System.Windows.Forms.ColumnHeader productionDateColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.MenuStrip viewMenuStrip;
        private System.Windows.Forms.ToolStrip viewToolStrip;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton removeToolStripButton;
        private System.Windows.Forms.ContextMenuStrip viewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel vehicleCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripComboBox filterToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
    }
}