using Energierechner.Auth.Models;
using Energierechner.SharedModels.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Energierechner.Auth.Data;

public static class ModelBuilderExtension
{
    public static void SeddData(this ModelBuilder builder)
    {
        string adminUserId = Guid.NewGuid().ToString();
        string adminRoleId = Guid.NewGuid().ToString();


        builder.Entity<IdentityRole>().HasData(new IdentityRole 
        {
            Id = adminRoleId,
            Name = nameof(Role.Admin),
            NormalizedName = nameof(Role.Admin).ToUpper(),
            ConcurrencyStamp = nameof(Role.Admin).ToUpper()
        });

        var user = new AppUser
        {
            Id = adminUserId,
            Name = nameof(Role.Admin),
            UserName = "admin@energierechner.de",
            NormalizedUserName = "admin@energierechner.de",
            Email = "admin@energierechner.de",
            NormalizedEmail = "admin@energierechner.de"
        };
        PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
        user.PasswordHash = ph.HashPassword(user, "!Admin_123");

        builder.Entity<AppUser>().HasData(user);

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> 
        {
            RoleId = adminRoleId,
            UserId = adminUserId
        });
    }
}
