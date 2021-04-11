
namespace PAIN_WF
{
    partial class VehicleTypeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.truckPictureBox = new System.Windows.Forms.PictureBox();
            this.bikePictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.carPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.truckPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bikePictureBox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // carPictureBox
            // 
            this.carPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carPictureBox.Image = global::PAIN_WF.Properties.Resources.car;
            this.carPictureBox.Location = new System.Drawing.Point(3, 3);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(113, 164);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPictureBox.TabIndex = 0;
            this.carPictureBox.TabStop = false;
            this.carPictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // truckPictureBox
            // 
            this.truckPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckPictureBox.Image = global::PAIN_WF.Properties.Resources.truck;
            this.truckPictureBox.Location = new System.Drawing.Point(122, 3);
            this.truckPictureBox.Name = "truckPictureBox";
            this.truckPictureBox.Size = new System.Drawing.Size(113, 164);
            this.truckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truckPictureBox.TabIndex = 1;
            this.truckPictureBox.TabStop = false;
            this.truckPictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // bikePictureBox
            // 
            this.bikePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bikePictureBox.Image = global::PAIN_WF.Properties.Resources.bike;
            this.bikePictureBox.Location = new System.Drawing.Point(241, 3);
            this.bikePictureBox.Name = "bikePictureBox";
            this.bikePictureBox.Size = new System.Drawing.Size(115, 164);
            this.bikePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bikePictureBox.TabIndex = 2;
            this.bikePictureBox.TabStop = false;
            this.bikePictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // VehicleTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VehicleTypeControl";
            this.Size = new System.Drawing.Size(359, 170);
            this.Load += new System.EventHandler(this.VehicleTypeControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.PictureBox truckPictureBox;
        private System.Windows.Forms.PictureBox bikePictureBox;
    }
}
