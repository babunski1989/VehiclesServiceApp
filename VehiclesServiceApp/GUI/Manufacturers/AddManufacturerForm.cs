using System;
using System.Windows.Forms;
using VehiclesServiceApp.Buisenss;
using VehiclesServiceApp.Buisenss.Operations;

namespace VehiclesServiceApp.GUI
{
    public partial class AddManufacturerForm : Form
    {
        public AddManufacturerForm()
        {
            InitializeComponent();
        }

        private void btnSaveManufacurer_Click(object sender, EventArgs e)
        {
            var operation = new AddManufacturerOperation
            {
                Name = tbAddManufacurer.Text
            };
            var result = OperationManager.Instance.Exec(operation);
            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelManName_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
