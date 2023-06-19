using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Buisenss.DTO;

namespace VehiclesServiceApp.Buisenss.Operations
{
    public class GetManufacturersOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            return new OperationResult()
            {
                Data = Entities.Manufacturers.Select(x => new ManufacturerDTO
                {
                    Id = x.Id,
                    ModelNames = x.Models.Select(y => y.Name),
                    Name = x.Name
                }).ToList()
            };
        }
    }
}
