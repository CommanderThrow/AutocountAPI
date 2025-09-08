using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022MultiLocationReorderAdvice
{
    public string ItemCode { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal? ReorderLevel { get; set; }

    public decimal? ReorderQty { get; set; }
}
