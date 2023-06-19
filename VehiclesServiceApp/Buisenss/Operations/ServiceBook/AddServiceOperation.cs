using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServiceApp.Data;

namespace VehiclesServiceApp.Buisenss.Operations.ServiceBook
{
    public class AddServiceOperation : EfOperation
    {
        public int VehicleId { get; set; }
        public DateTime ScheduledFor { get; set; }
        public int ServiceTypeId { get; set; }

        public override OperationResult Execute()
        {
            Entities.ServiceSchedules.Add(new ServiceSchedule
            {
                VehicleId = VehicleId,
                ScheduledFor = ScheduledFor,
                ServiceTypeId = ServiceTypeId
            });
            Entities.SaveChanges();

            return new OperationResult();
        }
    }
}
