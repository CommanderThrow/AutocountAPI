using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Lorry
{
    public string LorryNo { get; set; } = null!;

    public string? Description { get; set; }

    public decimal M3 { get; set; }

    public decimal Weight { get; set; }

    public string IsActive { get; set; } = null!;

    public string? IsAvailable { get; set; }
}
