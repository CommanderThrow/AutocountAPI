using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCsgnitemBatchBalQty
{
    public string ItemCode { get; set; } = null!;

    public string? BatchNo { get; set; }

    public decimal? BalQty { get; set; }
}
