using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VArdebitNoteDetail
{
    public long? DocKey { get; set; }

    public int Seq { get; set; }

    public string? AccNo { get; set; }

    public decimal ToAccountRate { get; set; }

    public string? Description { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public string? TaxCode { get; set; }

    public string SupplyPurchase { get; set; } = null!;

    public string? TaxPermitNo { get; set; }

    public string? TariffCode { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? TaxAdjustment { get; set; }

    public decimal? LocalTaxAdjustment { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? LocalSubTotal { get; set; }

    public decimal? Amount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? LocalNetAmount { get; set; }

    public decimal? KnockOffAmount { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public decimal? DocTaxRate { get; set; }
}
