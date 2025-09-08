using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022BosuggestDtl
{
    public string SuggestDtlGuid { get; set; } = null!;

    public string? LotNo { get; set; }

    public string? DocNo { get; set; }

    public string? FromDocType { get; set; }

    public string? FromDocNo { get; set; }

    public long? FromDtlKey { get; set; }

    public int? Seq { get; set; }

    public string? ItemCode { get; set; }

    public string? Description { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public decimal? Qty { get; set; }

    public decimal? TotalActualQty { get; set; }

    public decimal? SuggestQty { get; set; }
}
