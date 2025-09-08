using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class MyeinvoiceSupplierItemMapping
{
    public string CreditorCode { get; set; } = null!;

    public string SupplierItemDescription { get; set; } = null!;

    public string SupplierMeasurement { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }
}
