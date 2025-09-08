using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class SgeinvoiceSupplierItemMapping
{
    public string CreditorCode { get; set; } = null!;

    public string SupplierItemCode { get; set; } = null!;

    public string SupplierUnitCode { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }
}
