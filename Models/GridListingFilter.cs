using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class GridListingFilter
{
    public long AutoKey { get; set; }

    public string FilterName { get; set; } = null!;

    public string? Template { get; set; }

    public string IsDefault { get; set; } = null!;
}
