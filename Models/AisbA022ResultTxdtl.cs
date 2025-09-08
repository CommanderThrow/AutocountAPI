using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultTxdtl
{
    public int DtlKey { get; set; }

    public string Guid { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Qty { get; set; }

    public string? BatchNo { get; set; }

    public decimal? Rate { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public int? OverTransQtyApprove { get; set; }

    public string? FromDtlKey { get; set; }

    public string? ParentGuid { get; set; }

    public string? Seq { get; set; }
}
