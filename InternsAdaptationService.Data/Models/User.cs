using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Data.Models;

public class User: IdentityUser<Guid>
{
    public required string Name { get; set; }

    public required string Surname { get; set; }

    public string? MiddleName { get; set; }

    public string? DesciptionProfile { get; set; }

    public string? Telegram { get; set; }

    public string? VK { get; set; }
}
