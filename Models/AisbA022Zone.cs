using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Zone
{
    public string ZoneCode { get; set; } = null!;

    public string? ParentCode { get; set; }

    public string? ShortCode { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public int? ColorCode { get; set; }
}
