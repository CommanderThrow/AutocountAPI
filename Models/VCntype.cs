using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCntype
{
    public string Cntype { get; set; } = null!;

    public string? CntypeDescription { get; set; }
}
