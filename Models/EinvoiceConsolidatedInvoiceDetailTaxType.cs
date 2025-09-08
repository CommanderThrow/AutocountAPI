using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceConsolidatedInvoiceDetailTaxType
{
    public long CitaxTypeKey { get; set; }

    public long CidocKey { get; set; }

    public long CidtlKey { get; set; }

    public string? TaxType { get; set; }

    public string? Description { get; set; }

    public string? TaxExemptionReason { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? Tax { get; set; }
}
