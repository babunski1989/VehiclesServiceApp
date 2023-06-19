using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Data;

namespace VehiclesServiceApp.Buisenss.Operations
{
    public class AddManufacturerOperation : EfOperation
    {
        public string Name { get; set; }
        public override OperationResult Execute()
        {
            Entities.Manufacturers.Add(new Manufacturer
            {
                Name = Name,
            });
            Entities.SaveChanges();
            return new OperationResult();
        }
    }
}
