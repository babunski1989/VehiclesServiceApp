using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.Operations
{
    public class DeleteVehicleOperation : EfOperation
    {
        public int Id { get; set; }
        public override OperationResult Execute()
        {
            var vehicle = Entities.Vehicles.Find(Id);
            Entities.Vehicles.Remove(vehicle);
            Entities.SaveChanges();

            return new OperationResult();
        }
    }
}
