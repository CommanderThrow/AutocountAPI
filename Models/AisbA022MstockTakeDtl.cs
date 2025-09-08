using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022MstockTakeDtl
{
    public string MstdtlId { get; set; } = null!;

    public string Mstid { get; set; } = null!;

    public int? Seq { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Discount { get; set; }

    public decimal? DiscountAmt { get; set; }

    public decimal? StockBalance { get; set; }

    public decimal? StockTakeQty { get; set; }

    public decimal? Ams { get; set; }

    public decimal? SuggestQty { get; set; }

    public decimal? FinalQty { get; set; }

    public decimal? SuggestedQty { get; set; }

    public decimal? SuggestReturnQty { get; set; }

    public decimal? ReturnQty { get; set; }
}
