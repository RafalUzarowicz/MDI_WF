using System;
using System.Windows.Forms;

namespace PAIN_WF
{
    public partial class MainForm : Form
    {
        // Our model
        private Vehicles Vehicles { get; } = new Vehicles();
        public MainForm()
        {
            InitializeComponent();
        }

        private void newWindowButton_Click(object sender, EventArgs e)
        {
            ShowNewWindow();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // One window need to exist always so we create one on start.
            ShowNewWindow();
        }

        private void ShowNewWindow()
        {
            VehiclesForm vehiclesForm = new VehiclesForm(Vehicles);
            vehiclesForm.MdiParent = this;
            vehiclesForm.Show();
        }
    }
}
