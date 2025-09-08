using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class GridListingFilterUser
{
    public long AutoKey { get; set; }

    public string FilterName { get; set; } = null!;

    public string UserId { get; set; } = null!;
}
