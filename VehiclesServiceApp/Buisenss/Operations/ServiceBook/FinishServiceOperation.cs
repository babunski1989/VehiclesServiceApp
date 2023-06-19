using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.Operations.ServiceBook
{
    public class FinishServiceOperation : EfOperation
    {
        public int Id { get; set; } 
        public decimal Price { get; set; }
        public string AdditionalInfo { get; set; }  
        public override OperationResult Execute()
        {
            var service = Entities.ServiceSchedules.Find(Id);

            service.AdditionalInfo = AdditionalInfo;
            service.Price = Price;
            service.FinishedAt = DateTime.Now;
            Entities.SaveChanges();

            return new OperationResult();
        }
    }
}
