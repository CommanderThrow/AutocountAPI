using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VTaxCode
{
    public string TaxCode { get; set; } = null!;

    public string? TaxCodeDescription { get; set; }

    public decimal TaxRate { get; set; }

    public string? TaxAccNo { get; set; }

    public string? GovtTaxCode { get; set; }

    public int AccountingBasis { get; set; }

    public string AddToCost { get; set; } = null!;
}
