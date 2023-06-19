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
using VehiclesServiceApp.Data;
using VehiclesServiceApp.GUI;
using VehiclesServiceApp.GUI.Vehicles;

namespace VehiclesServiceApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnManufacturers_Click(object sender, EventArgs e)
        {
            var window = new ManufacturersForm();
            window.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            (new ServiceBookForm()).Show();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            var window = new VehiclesForm();
            window.Show();
        }
    }
}
