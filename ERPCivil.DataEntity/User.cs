using System;
using System.Collections.Generic;

namespace ERPCivil.DataEntity;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? PasswordHash { get; set; }

    public string? PasswordSalt { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? ContactNo { get; set; }

    public string? Address { get; set; }

    public int? RoleId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Role RoleName {  get; set; }
}
