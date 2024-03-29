using System.ComponentModel.DataAnnotations;

namespace Energierechner.Service.Models
{
    public class ElectricityMeterModel
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string ElectricityMeterNumber { get; set; } = string.Empty;

        [Required]
        public double BasicPrice { get; set; }

        [Required]
        public double UnitPreice { get; set; }

        [Required]
        public uint ConsumptionTarget { get; set; }

        [Required]
        public double MonthlyPayment { get; set;}


        public virtual ICollection<ElectricityMeterReadingsModel>? ElectricityReadings { get; set; }
    }
}
