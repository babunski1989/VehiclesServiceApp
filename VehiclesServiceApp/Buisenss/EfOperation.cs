using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Data;

namespace VehiclesServiceApp.Buisenss
{
    public abstract class EfOperation : Operation
    {
        protected CarServiceEntities Entities { get; set; }
        protected EfOperation()
        {
            Entities = new CarServiceEntities();
        }
    }
}
