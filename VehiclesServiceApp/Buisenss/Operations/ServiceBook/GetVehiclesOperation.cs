using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Buisenss.DTO;

namespace VehiclesServiceApp.Buisenss.Operations.ServiceBook
{
    public class GetVehiclesOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            return new OperationResult
            {
                Data = Entities.Vehicles.Select(x => new VehiclesDTO
                {
                    Id = x.Id,
                    Label = x.Label,
                    Model = x.Model.Name,
                    Manufacturer = x.Model.Manufacturer.Name,
                    Registration = x.Registrations.Any() ?
                    x.Registrations.OrderByDescending(y => y.IssuedAt)
                                   .FirstOrDefault()
                                   .RegistrationPlate
                                   .RegistrationPlate1 : "N/A"
                }).ToList()
            };
        }
    }
}
