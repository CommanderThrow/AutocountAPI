using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Amsdtl
{
    public string AmsdtlId { get; set; } = null!;

    public string Amsid { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Frequency { get; set; }

    public decimal? BufferQty { get; set; }

    public decimal? Ams { get; set; }

    public decimal? SuggestQty { get; set; }

    public int? Seq { get; set; }
}
