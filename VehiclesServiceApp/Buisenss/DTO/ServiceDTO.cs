using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServiceApp.Buisenss.DTO
{
    public class ServiceDTO : BaseDTO
    {
        [DisplayName("Ozanaka")]
        public string Label { get; set; }

        [DisplayName("Zakazan")]
        public DateTime ScheduledFor { get; set; }

        [DisplayName("Zavrsen")]
        public DateTime? FinishedAt { get; set; }

        [DisplayName("Vrsta servisa")]
        public string ServiceType { get; set; }

        [DisplayName("Cena")]
        public decimal? Price { get; set; }

        [DisplayName("Dodatne informacije")]
        public string AdditionalInfo { get; set; }

        [DisplayName("Tablice")]
        public string Plates { get; set; }

        [DisplayName("Je zavrsen")]
        public string IsFinished => FinishedAt.HasValue ? "Da" : "Ne";
        [Browsable(false)]
        public bool IsfinishedDeveloper => FinishedAt.HasValue;
    }
}
