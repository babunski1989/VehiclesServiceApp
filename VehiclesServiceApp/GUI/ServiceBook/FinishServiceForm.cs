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
using VehiclesServiceApp.Buisenss.Operations.ServiceBook;

namespace VehiclesServiceApp.GUI.ServiceBook
{
    public partial class FinishServiceForm : Form
    {
        private int id;
        public FinishServiceForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var operation = new FinishServiceOperation
            {
                AdditionalInfo = tbAdditionalInfo.Text,
                Id = id,
                Price = decimal.Parse(tbPrice.Text)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
