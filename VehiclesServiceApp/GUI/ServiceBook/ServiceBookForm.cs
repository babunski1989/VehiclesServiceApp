using System.Collections.Generic;
using System.Windows.Forms;
using VehiclesServiceApp.Buisenss;
using VehiclesServiceApp.Buisenss.DTO;
using VehiclesServiceApp.Buisenss.Operations;
using VehiclesServiceApp.GUI.ServiceBook;

namespace VehiclesServiceApp.GUI
{
    public partial class ServiceBookForm : Form
    {
        public ServiceBookForm()
        {
            InitializeComponent();
            LoadServices();
            LoadComboBox();
            cbServiceFinished.SelectedIndex = 0;
        }

        private void LoadComboBox()
        {
            var options = new List<object>
            {
                new
                {
                    Id=0,
                    Val="All"
                },
                new
                {
                    Id=1,
                    Val="Serviced"
                },
                new
                {
                    Id=2,
                    Val="Not finished"
                }
            };
            cbServiceFinished.DisplayMember = "Val";
            cbServiceFinished.ValueMember = "Id";
            cbServiceFinished.DataSource = options;
        }

        private void LoadServices()
        {
            var operation = new GetServicesOperation
            {
                Keyword = tbKeyword.Text,
                ServiceFinished = cbxFinished.Checked
                //ServiceFinished = (int)cbServiceFinished.SelectedValue
            };
            var result = OperationManager.Instance.Exec(operation);

            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            dgvServices.DataSource = result.Data;
        }

        private void btnSchedule_Click(object sender, System.EventArgs e)
        {
            var window = new ScheduleServiceForm();
            var res = window.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Service successfuly scheduled");
                LoadServices();
            }
        }

        private void btnFinishService_Click(object sender, System.EventArgs e)
        {
            var service = dgvServices.SelectedRows[0].DataBoundItem as ServiceDTO;
            var window = new FinishServiceForm(service.Id);
            var result = window.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadServices();
                MessageBox.Show("Service successfully finished");
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var service = dgvServices.SelectedRows[0].DataBoundItem as ServiceDTO;
            if (service.IsfinishedDeveloper)
            {
                btnFinishService.Enabled = false;
            }
            else
            {
                btnFinishService.Enabled = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e) => LoadServices();

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) => LoadServices();

        private void cbServiceFinished_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadServices();
        }

        private void cbxFinished_CheckedChanged(object sender, System.EventArgs e)
        {
            LoadServices();
        }
    }
}
