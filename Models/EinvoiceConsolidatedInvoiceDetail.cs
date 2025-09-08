using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceConsolidatedInvoiceDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public int Seq { get; set; }

    public string Classification { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? Tax { get; set; }

    public decimal? SubTotalExTax { get; set; }

    public decimal? SubTotal { get; set; }

    public string? PaymentMode { get; set; }
}
