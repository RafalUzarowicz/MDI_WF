using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PAIN_WF
{
    public partial class VehicleForm : Form
    {
        #region Data

        private Vehicle Vehicle
        {
            get;
        }

        public string VehicleBrand
        {
            get
            {
                return brandTextBox.Text;
            }
        }

        public long VehicleMaxSpeed
        {
            get
            {
                return long.Parse(maxSpeedTextBox.Text);
            }
        }

        public DateTime VehicleProductionDate
        {
            get
            {
                return productionDateTimePicker.Value;
            }
        }

        public VehicleType VehicleType
        {
            get;
            set;
        }

        #endregion

        public VehicleForm(Vehicle vehicle)
        {
            Vehicle = vehicle;
            InitializeComponent();
            vehicleTypeControl.TypeChanged += VehicleTypeControl_TypeChanged;
        }

        #region Events handling

        // Vehicle type control event handling
        private void VehicleTypeControl_TypeChanged(VehicleType vehicleType)
        {
            VehicleType = vehicleType;
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            if (Vehicle != null)
            {
                brandTextBox.Text = Vehicle.Brand;
                maxSpeedTextBox.Text = Vehicle.MaxSpeed.ToString();
                productionDateTimePicker.Value = Vehicle.ProductionDate;
                vehicleTypeControl.Type = Vehicle.Type;
            }
            else
            {
                brandTextBox.Text = "Audi";
                maxSpeedTextBox.Text = 100.ToString();
                productionDateTimePicker.Value = new DateTime(2001, 5, 3);
                vehicleTypeControl.Type = VehicleType.Car;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void maxSpeedTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !CheckMaxSpeed(maxSpeedTextBox.Text);
        }

        private void maxSpeedTextBox_Validated(object sender, EventArgs e)
        {
            vehicleErrorProvider.SetError(maxSpeedTextBox, "");
        }

        private void maxSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckMaxSpeed(maxSpeedTextBox.Text);
        }

        #endregion

        #region Private methods

        private bool CheckMaxSpeed(string text)
        {
            try
            {
                long index = long.Parse(maxSpeedTextBox.Text);
                vehicleErrorProvider.SetError(maxSpeedTextBox, "");
                return true;
            }
            catch (Exception exception)
            {
                maxSpeedTextBox.Select(0, maxSpeedTextBox.Text.Length);
                vehicleErrorProvider.SetError(maxSpeedTextBox, "Max speed must be a number!");
                return false;
            }
        }

        #endregion
    }
}
