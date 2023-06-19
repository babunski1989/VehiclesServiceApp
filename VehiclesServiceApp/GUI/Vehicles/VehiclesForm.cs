using System;
using System.Windows.Forms;
using VehiclesServiceApp.Buisenss;
using VehiclesServiceApp.Buisenss.DTO;
using VehiclesServiceApp.Buisenss.Operations;
using VehiclesServiceApp.Buisenss.Operations.ServiceBook;

namespace VehiclesServiceApp.GUI.Vehicles
{
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            var operation = new GetVehiclesOperation();
            var result = OperationManager.Instance.Exec(operation);
            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            dgvVehicles.DataSource = result.Data;
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            var window = new AddVehicleForm();
            var result = window.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadVehicles();
                MessageBox.Show("Vehicle successfully added");
            }
        }

        private void deleteVehicle_Click(object sender, EventArgs e)
        {
            var selected = dgvVehicles.SelectedRows[0].DataBoundItem as VehiclesDTO;
            var operation = new DeleteVehicleOperation { Id = selected.Id };
            var result = OperationManager.Instance.Exec(operation);
            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            LoadVehicles();
            MessageBox.Show("Vehicle successfully deleted");
        }
    }
}
