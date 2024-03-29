using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Energierechner.Service.Models;

public class ElectricityMeterReadingsModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public uint Reading { get; set; }


    public Guid ElectricityMeterId { get; set; }

    [ForeignKey(nameof(ElectricityMeterId))]
    public ElectricityMeterModel? ElectricityMeterModel { get; set; }
}
