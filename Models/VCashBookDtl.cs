using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCashBookDtl
{
    public long DocKey { get; set; }

    public decimal ToAccountRate { get; set; }

    public long DtlKey { get; set; }

    public int Seq { get; set; }

    public string? Description { get; set; }

    public string? FurtherDescription { get; set; }

    public decimal? Amount { get; set; }

    public decimal? LocalAmount { get; set; }

    public decimal? Rchqamount { get; set; }

    public string? TaxPermitNo { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? TaxAdjustment { get; set; }

    public decimal? LocalTaxAdjustment { get; set; }

    public decimal? HasValueTaxableAmt { get; set; }

    public string? TaxRefNo { get; set; }

    public string? TaxBrno { get; set; }

    public string? TaxRegisterNo { get; set; }

    public DateTime? TaxBillDate { get; set; }

    public string? TaxBname { get; set; }

    public string? TariffCode { get; set; }

    public decimal? DocTaxRate { get; set; }

    public string InclusiveTax { get; set; } = null!;

    public decimal? AmountExTax { get; set; }

    public decimal? LocalAmountExTax { get; set; }

    public decimal? AmountWithTax { get; set; }

    public decimal? LocalAmountWithTax { get; set; }

    public string? ProjNo { get; set; }

    public string? ProjectDescription { get; set; }

    public string? ProjectDesc2 { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptDescription { get; set; }

    public string? DeptDesc2 { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxCodeDescription { get; set; }

    public decimal? TaxRate { get; set; }

    public string? TaxAccNo { get; set; }

    public string? GovtTaxCode { get; set; }

    public int? AccountingBasis { get; set; }

    public string? AddToCost { get; set; }

    public string? AccNo { get; set; }

    public string? AccDescription { get; set; }

    public string? AccDesc2 { get; set; }

    public string? AccType { get; set; }

    public string? SpecialAccType { get; set; }

    public string? AccCurrencyCode { get; set; }

    public string? SalesAgent { get; set; }

    public string? SalesAgentDescription { get; set; }

    public string? SalesAgentDesc2 { get; set; }

    public byte[]? SalesAgentSignature { get; set; }
}
