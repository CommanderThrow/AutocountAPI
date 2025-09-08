using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022LorryUser
{
    public string UserId { get; set; } = null!;

    public string? DefaultLorryNo { get; set; }

    public string IsActive { get; set; } = null!;

    public string Type { get; set; } = null!;
}
