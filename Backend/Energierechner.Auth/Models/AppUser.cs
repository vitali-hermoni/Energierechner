using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Energierechner.Auth.Models;

public class AppUser : IdentityUser
{
    [Required]
    public string Name { get; set; } = string.Empty;
}