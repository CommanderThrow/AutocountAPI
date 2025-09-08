using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class SgeinvoiceAggregatedTransactionDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public string? Description { get; set; }

    public string? GovtTaxCode { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? SubTotalExTax { get; set; }

    public decimal? LocalSubTotal { get; set; }

    public decimal? LocalSubTotalExTax { get; set; }
}
