using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022BinTransaction
{
    public string DtlGuid { get; set; } = null!;

    public DateTime? RefDocDate { get; set; }

    public DateTime? RefDocCreatedDateTime { get; set; }

    public string? RefDocType { get; set; }

    public string? RefDocNo { get; set; }

    public string? BinCode { get; set; }

    public string? LotNo { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public string? BatchNo { get; set; }

    public decimal? Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
