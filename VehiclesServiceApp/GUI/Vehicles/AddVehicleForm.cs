using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehiclesServiceApp.Buisenss;
using VehiclesServiceApp.Buisenss.DTO;
using VehiclesServiceApp.Buisenss.Operations;

namespace VehiclesServiceApp.GUI.Vehicles
{
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
            LoadModels();
        }

        private void LoadModels()
        {
            cbModel.ValueMember = "Id";
            cbModel.DisplayMember = "Name";

            var operation = new GetModelsOperation();
            var result = OperationManager.Instance.Exec(operation);
            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            cbModel.DataSource = result.Data;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selected = cbModel.SelectedItem as ModelDTO;
            var operation = new AddVehicleOperation
            {
                Label = tbLabel.Text,
                ModelId = selected.Id
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
