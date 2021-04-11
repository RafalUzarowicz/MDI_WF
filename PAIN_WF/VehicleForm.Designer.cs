
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.productionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeControl = new PAIN_WF.VehicleTypeControl();
            this.vehicleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            brandLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            brandLabel.Location = new System.Drawing.Point(3, 0);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(78, 57);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "Brand";
            brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 286);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 239);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(509, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(87, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(121, 38);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Okay";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(298, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelButton.Size = new System.Drawing.Size(121, 38);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanel3.Controls.Add(brandLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.maxSpeedLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.productionDateLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.typeLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.brandTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.productionDateTimePicker, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.maxSpeedTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.vehicleTypeControl, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(509, 230);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxSpeedLabel.Location = new System.Drawing.Point(3, 57);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(78, 57);
            this.maxSpeedLabel.TabIndex = 1;
            this.maxSpeedLabel.Text = "Max speed";
            this.maxSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionDateLabel.Location = new System.Drawing.Point(3, 114);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(78, 57);
            this.productionDateLabel.TabIndex = 2;
            this.productionDateLabel.Text = "Production date";
            this.productionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Location = new System.Drawing.Point(3, 171);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(78, 59);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandTextBox.Location = new System.Drawing.Point(87, 3);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(392, 20);
            this.brandTextBox.TabIndex = 4;
            // 
            // productionDateTimePicker
            // 
            this.productionDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionDateTimePicker.Location = new System.Drawing.Point(87, 117);
            this.productionDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.productionDateTimePicker.Name = "productionDateTimePicker";
            this.productionDateTimePicker.Size = new System.Drawing.Size(392, 20);
            this.productionDateTimePicker.TabIndex = 5;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxSpeedTextBox.Location = new System.Drawing.Point(87, 60);
            this.maxSpeedTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(392, 20);
            this.maxSpeedTextBox.TabIndex = 6;
            this.maxSpeedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.maxSpeedTextBox_Validating);
            this.maxSpeedTextBox.Validated += new System.EventHandler(this.maxSpeedTextBox_Validated);
            // 
            // vehicleTypeControl
            // 
            this.vehicleTypeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypeControl.Location = new System.Drawing.Point(87, 174);
            this.vehicleTypeControl.Name = "vehicleTypeControl";
            this.vehicleTypeControl.Size = new System.Drawing.Size(419, 53);
            this.vehicleTypeControl.TabIndex = 7;
            this.vehicleTypeControl.Type = PAIN_WF.VehicleType.Car;
            // 
            // vehicleErrorProvider
            // 
            this.vehicleErrorProvider.ContainerControl = this;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 286);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
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