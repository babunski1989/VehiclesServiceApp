using System;
using System.Windows.Forms;
using VehiclesServiceApp.Buisenss;
using VehiclesServiceApp.Buisenss.DTO;
using VehiclesServiceApp.Buisenss.Operations;

namespace VehiclesServiceApp.GUI
{
    public partial class EditManufacturerForm : Form
    {
        ManufacturerDTO manufacturer;
        public EditManufacturerForm(ManufacturerDTO manufacturer)
        {
            InitializeComponent();
            this.manufacturer = manufacturer;
            this.tbManufacturerName.Text = manufacturer.Name;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var operation = new UpdateManufacturers
            {
                Id = manufacturer.Id,
                Name = tbManufacturerName.Text
            };
            var result = OperationManager.Instance.Exec(operation);
            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
