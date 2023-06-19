using System.Collections.Generic;
using System.Linq;
using VehiclesServiceApp.Buisenss.DTO;

namespace VehiclesServiceApp.Buisenss
{
    public class OperationResult
    {
        public IEnumerable<string> Errors { get; set; } = new List<string>();
        public IEnumerable<BaseDTO> Data { get; set; } = new List<BaseDTO>();
        public string FirstError => Errors.FirstOrDefault();
        public bool IsSuccessful => !Errors.Any();//Erros.Count() == 0
    }
}
