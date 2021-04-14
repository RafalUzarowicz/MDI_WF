using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PAIN_WF
{
    public partial class VehicleTypeControl : UserControl
    {
        [BrowsableAttribute(true)]
        [Category("Vehicle type")]
        [EditorAttribute(typeof(VehicleTypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public VehicleType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Vehicle type")]
        [Description("Invoked when vehicle type changes")]
        public event Action<VehicleType> TypeChanged;

        private VehicleType type;

        public VehicleTypeControl()
        {
            type = VehicleType.Car;
            InitializeComponent();
        }

        public VehicleTypeControl(VehicleType vehicleType = VehicleType.Car)
        {
            type = vehicleType;
            InitializeComponent();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            switch (type)
            {
                case VehicleType.Car:
                    carPictureBox.Visible = true;
                    truckPictureBox.Visible = false;
                    bikePictureBox.Visible = false;
                    break;
                case VehicleType.Truck:
                    carPictureBox.Visible = false;
                    truckPictureBox.Visible = true;
                    bikePictureBox.Visible = false;
                    break;
                case VehicleType.Bike:
                    carPictureBox.Visible = false;
                    truckPictureBox.Visible = false;
                    bikePictureBox.Visible = true;
                    break;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            int currType = (int)type + 1;
            currType = currType >= Enum.GetNames(typeof(VehicleType)).Length ? 0 : currType;
            type = (VehicleType)currType;
            TypeChanged?.Invoke(type);
            Invalidate();
        }
    }

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class VehicleTypeEditor : System.Drawing.Design.UITypeEditor
    {
        private Bitmap carBitmap = new Bitmap(global::PAIN_WF.Properties.Resources.car);
        private Bitmap truckBitmap = new Bitmap(global::PAIN_WF.Properties.Resources.truck);
        private Bitmap bikeBitmap = new Bitmap(global::PAIN_WF.Properties.Resources.bike);
        public VehicleTypeEditor()
        {
        }

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            if (value.GetType() != typeof(VehicleType))
                return value;

            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                VehicleTypeControl vehicleTypeControl = new VehicleTypeControl();
                vehicleTypeControl.Type = (VehicleType)value;
                edSvc.DropDownControl(vehicleTypeControl);

                // Return the value in the appropraite data format.
                if (value.GetType() == typeof(VehicleType))
                    return vehicleTypeControl.Type;
            }
            return value;
        }

        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            switch (e.Value)
            {
                case VehicleType.Car:
                    e.Graphics.DrawImage(carBitmap, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                    break;
                case VehicleType.Truck:
                    e.Graphics.DrawImage(truckBitmap, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                    break;
                case VehicleType.Bike:
                    e.Graphics.DrawImage(bikeBitmap, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                    break;
            }
        }

        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }
    }
}
