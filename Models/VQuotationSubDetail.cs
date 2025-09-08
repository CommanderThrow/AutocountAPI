using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VQuotationSubDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public int Seq { get; set; }

    public string? Description { get; set; }

    public string? Desc2 { get; set; }

    public string? FurtherDescription { get; set; }

    public decimal? SubQty { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? LocalSubTotal { get; set; }

    public string PrintOut { get; set; } = null!;

    public decimal? Rate { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public long? ParentDtlKey { get; set; }

    public decimal? DocTaxRate { get; set; }

    public string? SalesExemptionNo { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxCodeDescription { get; set; }

    public decimal? TaxRate { get; set; }

    public string? TaxAccNo { get; set; }

    public string? GovtTaxCode { get; set; }

    public int? AccountingBasis { get; set; }

    public string? AddToCost { get; set; }
}
