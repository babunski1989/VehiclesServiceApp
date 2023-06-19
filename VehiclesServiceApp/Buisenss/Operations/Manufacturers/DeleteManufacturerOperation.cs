using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.Operations
{
    public class DeleteManufacturerOperation : DeleteOperation
    {
        public override OperationResult Execute()
        {
            var manufacture = Entities.Manufacturers.Find(Id);
            Entities.Manufacturers.Remove(manufacture);
            Entities.SaveChanges();

            return new OperationResult();
        }
    }
}
