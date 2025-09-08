using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VItemUombalQty
{
    public string ItemCode { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public decimal Rate { get; set; }

    public decimal? BalQty { get; set; }
}
