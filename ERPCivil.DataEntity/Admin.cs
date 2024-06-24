using System;
using System.Collections.Generic;

namespace ERPCivil.DataEntity;

public partial class Admin
{
    public int AdminId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string? MobNo { get; set; }

    public string? UserName { get; set; }

    public string? PasswordHash { get; set; }

    public string? PasswordSalt { get; set; }

    public string? OrganisationName { get; set; }

    public string? Address { get; set; }

    public DateOnly? Doj { get; set; }

    public bool? IsActive { get; set; }
}
