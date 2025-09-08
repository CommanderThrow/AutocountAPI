using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022StockTake
{
    public string Guid { get; set; } = null!;

    public string? BinCode { get; set; }

    public string? ZoneCode { get; set; }

    public string? Indicator { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public string? LotNo { get; set; }

    public string? Barcode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public bool? Deleted { get; set; }

    public string? PostedToDocNo { get; set; }

    public string? PostedToDocType { get; set; }

    public string? DeviceId { get; set; }
}
