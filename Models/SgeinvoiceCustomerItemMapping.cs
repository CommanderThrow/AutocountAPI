using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class SgeinvoiceCustomerItemMapping
{
    public string DebtorCode { get; set; } = null!;

    public string CustomerItemCode { get; set; } = null!;

    public string CustomerUnitCode { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }
}
