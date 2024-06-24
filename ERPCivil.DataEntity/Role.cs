using System;
using System.Collections.Generic;

namespace ERPCivil.DataEntity;

public partial class Role
{
    public int RoleId { get; set; }

    public string? Designation { get; set; }

    public string? DeptName { get; set; }

    public string? Location { get; set; }

    public bool? IsActive { get; set; }
}
