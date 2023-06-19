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
using VehiclesServiceApp.Buisenss.Operations.ServiceBook;

namespace VehiclesServiceApp.GUI.ServiceBook
{
    public partial class ScheduleServiceForm : Form
    {
        public ScheduleServiceForm()
        {
            InitializeComponent();
            PopulateServiceTypes();
            PopulateVehicles();
        }

        private void PopulateVehicles()
        {
            cbVehicle.DisplayMember = "Label";
            cbVehicle.ValueMember = "Id";

            var operation = new GetVehiclesOperation();
            var result = OperationManager.Instance.Exec(operation);
            if (!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            cbVehicle.DataSource = result.Data;
        }

        private void PopulateServiceTypes()
        {
            cbServiceType.ValueMember = "Id";
            cbServiceType.DisplayMember = "Name";

            var operation = new GetServiceTypesOperation();
            var result = OperationManager.Instance.Exec(operation);
            if(!result.IsSuccessful)
            {
                MessageBox.Show(result.FirstError);
                return;
            }
            cbServiceType.DataSource = result.Data;
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            var service = cbServiceType.SelectedValue as ServiceTypeDTO;
            var vehicle = cbVehicle.SelectedValue as VehiclesDTO;
            var scheduledFor = dtScheduledFor.Value;

            var operation = new AddServiceOperation
            {
                ScheduledFor = scheduledFor,
                VehicleId = vehicle.Id,
                ServiceTypeId = service.Id
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
