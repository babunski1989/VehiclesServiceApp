using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.DTO
{
    public class VehiclesDTO : BaseDTO
    {
        public string Model { get; set; }
        public string Label { get; set; }
        public string Registration { get; set; }
        public string Manufacturer { get; set; }    
    }
}
