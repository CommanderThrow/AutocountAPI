using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Lot
{
    public string LotNo { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public string? BatchNo { get; set; }

    public decimal? BalQty { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? RefDocNo { get; set; }

    public string? RefDocType { get; set; }
}
