using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Buisenss.DTO;

namespace VehiclesServiceApp.Buisenss.Operations
{
    public class GetServicesOperation : EfOperation
    {
        public string Keyword { get; set; }
        public bool ServiceFinished { get; set; }

        public override OperationResult Execute()
        {
            var query = Entities.ServiceSchedules.AsQueryable();

            if (!string.IsNullOrEmpty(Keyword))
            {
                query = query.Where(x => x.Vehicle.Label.Contains(Keyword));
            }
            if (ServiceFinished)
            {
                query = query.Where(x => x.FinishedAt != null);
            }
            //if (ServiceFinished != 0 && ServiceFinished == 1)
            //{
            //    query = query.Where(x => x.FinishedAt != null);
            //}
            //else if (ServiceFinished != 0 && ServiceFinished == 2)
            //{
            //    query = query.Where(x => x.FinishedAt == null);
            //}

            return new OperationResult
            {
                Data = query.Select(x => new ServiceDTO
                {
                    Id = x.Id,
                    AdditionalInfo = x.AdditionalInfo,
                    FinishedAt = x.FinishedAt,
                    Label = x.Vehicle.Label,
                    Price = x.Price,
                    ScheduledFor = x.ScheduledFor,
                    ServiceType = x.ServiceType.Name,
                    Plates = x.Vehicle.Registrations.Any() ? x.Vehicle.Registrations.OrderByDescending(y => y.IssuedAt).FirstOrDefault().RegistrationPlate.RegistrationPlate1 : "N/A"
                }).ToList()
            };
        }
    }
}
