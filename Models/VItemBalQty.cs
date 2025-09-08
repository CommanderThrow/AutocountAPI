using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VItemBalQty
{
    public string ItemCode { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal? BalQty { get; set; }
}
