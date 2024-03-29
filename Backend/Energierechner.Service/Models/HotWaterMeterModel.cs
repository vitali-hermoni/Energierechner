using System.ComponentModel.DataAnnotations;

namespace Energierechner.Service.Models;

public class HotWaterMeterModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}
