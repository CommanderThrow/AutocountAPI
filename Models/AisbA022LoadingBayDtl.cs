using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022LoadingBayDtl
{
    public string LoadingBayDtlId { get; set; } = null!;

    public string? LoadingBayId { get; set; }

    public string? Area { get; set; }

    public decimal? Priority { get; set; }

    public string? Color { get; set; }
}
