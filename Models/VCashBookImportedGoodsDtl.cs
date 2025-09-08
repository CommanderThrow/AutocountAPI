using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCashBookImportedGoodsDtl
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public long ParentDtlKey { get; set; }

    public string? SourceType { get; set; }

    public long SourceDtlKey { get; set; }

    public string? SourceDtlType { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public decimal CurrencyRate { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? TaxAdjustment { get; set; }

    public decimal? LocalTaxAdjustment { get; set; }

    public string? TaxPermitNo { get; set; }

    public decimal? DocTaxRate { get; set; }

    public int Seq { get; set; }

    public string? ApivdocNo { get; set; }

    public string? ApivsupplierDocNo { get; set; }

    public string? ApivcompanyName { get; set; }

    public DateTime? ApivdocDate { get; set; }

    public string? ApivcurrencyCode { get; set; }

    public decimal? ApivcurrencyRate { get; set; }

    public string? ApivdtlAccNo { get; set; }

    public string? ApivdtlDescription { get; set; }

    public decimal? ApivdtlSubTotal { get; set; }

    public decimal? ApivdtlLocalSubTotal { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxCodeDescription { get; set; }

    public decimal? TaxRate { get; set; }

    public string? TaxAccNo { get; set; }

    public string? GovtTaxCode { get; set; }

    public int? AccountingBasis { get; set; }

    public string? AddToCost { get; set; }
}
