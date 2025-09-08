using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VDept
{
    public string DeptNo { get; set; } = null!;

    public string? DeptDescription { get; set; }

    public string? DeptDesc2 { get; set; }
}
