using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.DTO
{
    public class ManufacturerDTO : BaseDTO
    {
        public string Name { get; set; }
        [Browsable(false)]
        public IEnumerable<string> ModelNames { get; set; }
        public string Models => string.Join(", ", ModelNames);
    }
}
