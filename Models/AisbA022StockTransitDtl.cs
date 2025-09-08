using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022StockTransitDtl
{
    public string StockRequestDtlId { get; set; } = null!;

    public string? StockRequestId { get; set; }

    public long DtlKey { get; set; }

    public long? DocKey { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Description { get; set; }

    public string Uom { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal? TransitQty { get; set; }

    public decimal? TransferQty { get; set; }

    public decimal? Variance { get; set; }

    public decimal? AdjustedQty { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public string? BatchNo { get; set; }

    public int? Seq { get; set; }

    public decimal? Rate { get; set; }

    public string? Location { get; set; }

    public string? Remark { get; set; }
}
