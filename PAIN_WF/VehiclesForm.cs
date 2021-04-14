using System;
using System.Linq;
using System.Windows.Forms;

namespace PAIN_WF
{
    public partial class VehiclesForm : Form
    {
        private Vehicles Vehicles { get; }
        public VehiclesForm(Vehicles vehicles)
        {
            Vehicles = vehicles;
            InitializeComponent();
        }

        #region Basic events

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            // Prepare interface
            filterToolStripComboBox.SelectedIndex = 0;
            UpdateItems();
            UpdateCommandAvailability();
            // Add events handling
            Vehicles.AddVehicleEvent += Vehicles_vehicleAddEvent;
            Vehicles.EditVehicleEvent += Vehicles_vehicleEditEvent;
            Vehicles.RemoveVehicleEvent += Vehicles_vehicleRemoveEvent;
        }

        // Prevent last child from closing.
        private void VehiclesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.MdiFormClosing)
            {
                if (this.MdiParent.MdiChildren.Count() == 1)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region Filters and adding

        private void AddVehicle(Vehicle vehicle)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = vehicle;
            UpdateItem(item);
            vehiclesListView.Items.Add(item);
            UpdateVehicleCount();
        }

        private bool isVehicleFiltered(Vehicle vehicle)
        {
            switch (filterToolStripComboBox.SelectedIndex)
            {
                case 0: return true;
                case 1: return vehicle.MaxSpeed < 100;
                case 2: return vehicle.MaxSpeed >= 100;
                default: throw new Exception("Wrong filter");
            }
        }

        #endregion

        #region Model events handling

        private void Vehicles_vehicleAddEvent(Vehicle vehicle)
        {
            if (isVehicleFiltered(vehicle))
            {
                AddVehicle(vehicle);
            }
        }

        private void Vehicles_vehicleEditEvent(Vehicle vehicle)
        {
            // Find vehicle
            foreach (ListViewItem item in vehiclesListView.Items)
            {
                if (Object.ReferenceEquals(item.Tag, vehicle))
                {
                    if (isVehicleFiltered(vehicle))
                    {
                        // Vehicle passes the filtr
                        UpdateItem(item);
                    }
                    else
                    {
                        // Vehicle doesn's pass the filtr
                        vehiclesListView.Items.Remove(item);
                        UpdateVehicleCount();
                    }
                    return;
                }
            }
            // Vehicle not found
            if (isVehicleFiltered(vehicle))
            {
                AddVehicle(vehicle);
            }
        }

        private void Vehicles_vehicleRemoveEvent(Vehicle vehicle)
        {
            // Find vehicle
            foreach (ListViewItem item in vehiclesListView.Items)
            {
                if (Object.ReferenceEquals(item.Tag, vehicle))
                {
                    vehiclesListView.Items.Remove(item);
                    UpdateVehicleCount();
                    break;
                }
            }
        }

        #endregion

        #region Buttons actions

        private void addItem_Click(object sender, EventArgs e)
        {
            VehicleForm vehicleForm = new VehicleForm(null);
            if (vehicleForm.ShowDialog() == DialogResult.OK)
            {
                Vehicle vehicle = new Vehicle(vehicleForm.VehicleBrand, vehicleForm.VehicleMaxSpeed, vehicleForm.VehicleProductionDate, vehicleForm.VehicleType);

                Vehicles.AddVehicle(vehicle);
            }
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            if (vehiclesListView.SelectedItems.Count != 1)
            {
                return;
            }

            Vehicle vehicle = (Vehicle)vehiclesListView.SelectedItems[0].Tag;
            VehicleForm vehicleForm = new VehicleForm(vehicle);
            if (vehicleForm.ShowDialog() == DialogResult.OK)
            {
                vehicle.Brand = vehicleForm.VehicleBrand;
                vehicle.MaxSpeed = vehicleForm.VehicleMaxSpeed;
                vehicle.ProductionDate = vehicleForm.VehicleProductionDate;
                vehicle.Type = vehicleForm.VehicleType;

                Vehicles.EditVehicle(vehicle);
            }

        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if (vehiclesListView.SelectedItems.Count > 0)
            {
                while (vehiclesListView.SelectedItems.Count > 0)
                {
                    Vehicle vehicle = (Vehicle)vehiclesListView.SelectedItems[0].Tag;
                    vehiclesListView.Items.Remove(vehiclesListView.SelectedItems[0]);
                    Vehicles.RemoveVehicle(vehicle);
                }
            }
        }

        #endregion

        #region Selection changes
        private void viewListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandAvailability();
        }

        private void filterToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItems();
            vehiclesListView.Focus();
        }

        #endregion

        #region Merging

        private void VehiclesForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).mainStatusStrip);
            ToolStripManager.RevertMerge(((MainForm)MdiParent).mainToolStrip);

            ToolStripManager.Merge(viewStatusStrip, ((MainForm)MdiParent).mainStatusStrip);
            ToolStripManager.Merge(viewToolStrip, ((MainForm)MdiParent).mainToolStrip);
        }

        private void VehiclesForm_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).mainStatusStrip, viewStatusStrip);
            ToolStripManager.RevertMerge(((MainForm)MdiParent).mainToolStrip, viewToolStrip);
        }

        #endregion

        #region Updates
        private void UpdateVehicleCount()
        {
            vehicleCountToolStripStatusLabel.Text = vehiclesListView.Items.Count.ToString();
        }
        private void UpdateCommandAvailability()
        {
            editToolStripMenuItem.Enabled = vehiclesListView.SelectedItems.Count == 1;
            editToolStripButton.Enabled = vehiclesListView.SelectedItems.Count == 1;
            editMenuItem.Enabled = vehiclesListView.SelectedItems.Count == 1;

            removeMenuItem.Enabled = vehiclesListView.SelectedItems.Count > 0;
            removeToolStripButton.Enabled = vehiclesListView.SelectedItems.Count > 0;
            removeToolStripMenuItem.Enabled = vehiclesListView.SelectedItems.Count > 0;
        }

        private void UpdateItem(ListViewItem item)
        {
            Vehicle vehicle = (Vehicle)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = vehicle.Brand;
            item.SubItems[1].Text = vehicle.MaxSpeed.ToString();
            item.SubItems[2].Text = vehicle.ProductionDate.ToShortDateString();
            item.SubItems[3].Text = vehicle.Type.ToString();
        }

        private void UpdateItems()
        {
            vehiclesListView.Items.Clear();
            foreach (Vehicle vehicle in Vehicles.VehiclesList)
            {
                // Check filter
                if (isVehicleFiltered(vehicle))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = vehicle;
                    UpdateItem(item);
                    vehiclesListView.Items.Add(item);
                }
            }
            UpdateVehicleCount();
        }

        #endregion
    }
}
