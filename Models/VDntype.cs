using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VDntype
{
    public string Dntype { get; set; } = null!;

    public string? DntypeDescription { get; set; }
}
