using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB048ResultStockAssemblyDtl
{
    public string Guid { get; set; } = null!;

    public string DocGuid { get; set; } = null!;

    public int? Seq { get; set; }

    public string? ItemCode { get; set; }

    public string? BatchNo { get; set; }

    public string? Description { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public long? FromAsmorderDtlKey { get; set; }

    public decimal? OrderQty { get; set; }

    public string? Location { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }
}
