using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.Operations
{
    public class UpdateManufacturers : EfOperation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override OperationResult Execute()
        {
            var manufacturer = Entities.Manufacturers.Find(Id);
            manufacturer.Name = Name;
            Entities.SaveChanges();

            return new OperationResult();
        }
    }
}
