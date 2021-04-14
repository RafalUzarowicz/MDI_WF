
namespace PAIN_WF
{
    partial class VehicleForm
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
            System.Windows.Forms.Label brandLabel;
            this.splitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.productionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeControl = new PAIN_WF.VehicleTypeControl();
            this.vehicleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            brandLabel = new System.Windows.Forms.Label();
            this.splitTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.dataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            brandLabel.Location = new System.Drawing.Point(23, 20);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(58, 30);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "Brand";
            brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitTableLayoutPanel
            // 
            this.splitTableLayoutPanel.ColumnCount = 1;
            this.splitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.splitTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 1);
            this.splitTableLayoutPanel.Controls.Add(this.dataTableLayoutPanel, 0, 0);
            this.splitTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.splitTableLayoutPanel.Name = "splitTableLayoutPanel";
            this.splitTableLayoutPanel.RowCount = 2;
            this.splitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.63265F));
            this.splitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.splitTableLayoutPanel.Size = new System.Drawing.Size(447, 265);
            this.splitTableLayoutPanel.TabIndex = 0;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.CausesValidation = false;
            this.buttonsTableLayoutPanel.ColumnCount = 5;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonsTableLayoutPanel.Controls.Add(this.okButton, 1, 1);
            this.buttonsTableLayoutPanel.Controls.Add(this.cancelButton, 3, 1);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 219);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 3;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(441, 43);
            this.buttonsTableLayoutPanel.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(76, 9);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(104, 24);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Okay";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(259, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelButton.Size = new System.Drawing.Size(104, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dataTableLayoutPanel
            // 
            this.dataTableLayoutPanel.ColumnCount = 4;
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.dataTableLayoutPanel.Controls.Add(brandLabel, 1, 1);
            this.dataTableLayoutPanel.Controls.Add(this.maxSpeedLabel, 1, 2);
            this.dataTableLayoutPanel.Controls.Add(this.productionDateLabel, 1, 3);
            this.dataTableLayoutPanel.Controls.Add(this.typeLabel, 1, 4);
            this.dataTableLayoutPanel.Controls.Add(this.brandTextBox, 2, 1);
            this.dataTableLayoutPanel.Controls.Add(this.productionDateTimePicker, 2, 3);
            this.dataTableLayoutPanel.Controls.Add(this.maxSpeedTextBox, 2, 2);
            this.dataTableLayoutPanel.Controls.Add(this.vehicleTypeControl, 2, 4);
            this.dataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            this.dataTableLayoutPanel.RowCount = 6;
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(441, 210);
            this.dataTableLayoutPanel.TabIndex = 1;
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxSpeedLabel.Location = new System.Drawing.Point(23, 50);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(58, 30);
            this.maxSpeedLabel.TabIndex = 1;
            this.maxSpeedLabel.Text = "Max speed";
            this.maxSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionDateLabel.Location = new System.Drawing.Point(23, 80);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(58, 30);
            this.productionDateLabel.TabIndex = 2;
            this.productionDateLabel.Text = "Production date";
            this.productionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Location = new System.Drawing.Point(23, 110);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(58, 80);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandTextBox.Location = new System.Drawing.Point(87, 23);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(289, 20);
            this.brandTextBox.TabIndex = 4;
            // 
            // productionDateTimePicker
            // 
            this.productionDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionDateTimePicker.Location = new System.Drawing.Point(87, 83);
            this.productionDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.productionDateTimePicker.Name = "productionDateTimePicker";
            this.productionDateTimePicker.Size = new System.Drawing.Size(289, 20);
            this.productionDateTimePicker.TabIndex = 5;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxSpeedTextBox.Location = new System.Drawing.Point(87, 53);
            this.maxSpeedTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(289, 20);
            this.maxSpeedTextBox.TabIndex = 6;
            this.maxSpeedTextBox.TextChanged += new System.EventHandler(this.maxSpeedTextBox_TextChanged);
            this.maxSpeedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.maxSpeedTextBox_Validating);
            this.maxSpeedTextBox.Validated += new System.EventHandler(this.maxSpeedTextBox_Validated);
            // 
            // vehicleTypeControl
            // 
            this.vehicleTypeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypeControl.Location = new System.Drawing.Point(87, 113);
            this.vehicleTypeControl.Name = "vehicleTypeControl";
            this.vehicleTypeControl.Size = new System.Drawing.Size(316, 74);
            this.vehicleTypeControl.TabIndex = 0;
            this.vehicleTypeControl.Type = PAIN_WF.VehicleType.Car;
            this.vehicleTypeControl.TypeChanged += new System.Action<PAIN_WF.VehicleType>(this.VehicleTypeControl_TypeChanged);
            // 
            // vehicleErrorProvider
            // 
            this.vehicleErrorProvider.ContainerControl = this;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 265);
            this.Controls.Add(this.splitTableLayoutPanel);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.splitTableLayoutPanel.ResumeLayout(false);
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.dataTableLayoutPanel.ResumeLayout(false);
            this.dataTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel splitTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel dataTableLayoutPanel;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.Label productionDateLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.DateTimePicker productionDateTimePicker;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.ErrorProvider vehicleErrorProvider;
        private VehicleTypeControl vehicleTypeControl;
    }
}