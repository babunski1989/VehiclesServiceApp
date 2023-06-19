using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Buisenss.DTO;

namespace VehiclesServiceApp.Buisenss.Operations.ServiceBook
{
    public class GetServiceTypesOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            return new OperationResult
            {
                Data = Entities.ServiceTypes.Select(x => new ServiceTypeDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList()
            };
        }
    }
}
