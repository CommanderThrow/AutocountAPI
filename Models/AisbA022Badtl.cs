using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Badtl
{
    public string DtlGuid { get; set; } = null!;

    public string? DocNo { get; set; }

    public int? Seq { get; set; }

    public string? LotNo { get; set; }

    public string? BinCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Description { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public string? BatchNo { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public decimal? Qty { get; set; }
}
