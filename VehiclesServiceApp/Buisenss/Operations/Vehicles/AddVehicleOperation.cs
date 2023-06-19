using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Data;

namespace VehiclesServiceApp.Buisenss.Operations
{
    public class AddVehicleOperation : EfOperation
    {
        public int ModelId { get; set; }
        public string Label { get; set; }
        public override OperationResult Execute()
        {
            Entities.Vehicles.Add(new Vehicle
            {
                Label = Label,
                ModelId = ModelId
            });
            Entities.SaveChanges();

            return new OperationResult();
        }
    }
}
