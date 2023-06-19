using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Buisenss;
using VehiclesServiceApp.Buisenss.DTO;
using VehiclesServiceApp.Data;

namespace VehiclesServiceApp.GUI.Vehicles
{
    public class GetModelsOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            return new OperationResult
            {
                Data = Entities.Models.Select(x => new ModelDTO
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList()
            };
        }
    }
}
