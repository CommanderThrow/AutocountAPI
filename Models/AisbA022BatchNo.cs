using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022BatchNo
{
    public string Guid { get; set; } = null!;

    public string BatchNo { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string? DocType { get; set; }

    public string? DocId { get; set; }

    public string? DtlId { get; set; }

    public decimal Qty { get; set; }
}
