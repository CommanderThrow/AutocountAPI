using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Bin
{
    public string BinCode { get; set; } = null!;

    public string BinColumn { get; set; } = null!;

    public string BinRow { get; set; } = null!;

    public string ZoneCode { get; set; } = null!;

    public int? ColorCode { get; set; }

    public string Location { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Description { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Height { get; set; }

    public decimal? Width { get; set; }

    public decimal? Depth { get; set; }
}
