using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022MstockTakeDtlBatch
{
    public string MstdtlBid { get; set; } = null!;

    public string MstdtlId { get; set; } = null!;

    public string Mstid { get; set; } = null!;

    public string? BatchNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? Qty { get; set; }
}
