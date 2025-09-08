using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022RoutesDtl
{
    public string RoutesDtlId { get; set; } = null!;

    public string? RoutesId { get; set; }

    public string? Area { get; set; }

    public decimal? Priority { get; set; }

    public string? Color { get; set; }
}
