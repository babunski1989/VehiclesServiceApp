using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.DTO
{
    public abstract class BaseDTO
    {
        [Browsable(false)]
        public int Id { get; set; }
    }
}
