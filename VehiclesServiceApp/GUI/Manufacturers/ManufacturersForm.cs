using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VehiclesServiceApp.Buisenss;
using VehiclesServiceApp.Buisenss.DTO;
using VehiclesServiceApp.Buisenss.Operations;

namespace VehiclesServiceApp.GUI
{
    public partial class ManufacturersForm : Form
    {
        public ManufacturersForm()
        {
            InitializeComponent();
            LoadTable();
            dgvManufacturers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadTable()
        {
            var opertaion = new GetManufacturersOperation();
            var result = OperationManager.Instance.Exec(opertaion);

            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            this.dgvManufacturers.DataSource = result.Data;
        }

        private void btnUpdateManufacturer_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgvManufacturers.SelectedRows[0].DataBoundItem as ManufacturerDTO;
            var window = new EditManufacturerForm(selectedRow);

            var result = window.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadTable();
                MessageBox.Show("Successfully edited manufacturer");
            }
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            var window = new AddManufacturerForm();
            var result = window.ShowDialog();

            if(result == DialogResult.OK)
            {
                LoadTable();
                MessageBox.Show($"Manufacturer successfully added");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedManufacturer = this.dgvManufacturers.SelectedRows[0].DataBoundItem as ManufacturerDTO;

            if (MessageBox.Show($"Are you sure that you want to delte {selectedManufacturer.Name}", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (selectedManufacturer.Models.Any())
                {
                    MessageBox.Show("You can't delete this manufacturer");
                    return;
                }
                var operation = new DeleteManufacturerOperation { Id = selectedManufacturer.Id };
                var result = OperationManager.Instance.Exec(operation);

                if (!result.IsSuccessful)
                {
                    MessageBox.Show(result.FirstError);
                }
                this.DialogResult = DialogResult.OK;
            }
            LoadTable();
        }
    }
}
