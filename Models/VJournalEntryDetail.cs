using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VJournalEntryDetail
{
    public long DocKey { get; set; }

    public long DtlKey { get; set; }

    public int Seq { get; set; }

    public decimal ToAccountRate { get; set; }

    public string? Description { get; set; }

    public string? FurtherDescription { get; set; }

    public string? RefNo2 { get; set; }

    public decimal? Dr { get; set; }

    public decimal? Cr { get; set; }

    public decimal? HomeDr { get; set; }

    public decimal? HomeCr { get; set; }

    public string? TaxPermitNo { get; set; }

    public decimal? TaxAdjustment { get; set; }

    public decimal? LocalTaxAdjustment { get; set; }

    public decimal? TaxableDr { get; set; }

    public decimal? TaxableCr { get; set; }

    public decimal? LocalTaxableDr { get; set; }

    public decimal? LocalTaxableCr { get; set; }

    public decimal? TaxCurrencyTaxableDr { get; set; }

    public decimal? TaxCurrencyTaxableCr { get; set; }

    public decimal? TaxDr { get; set; }

    public decimal? TaxCr { get; set; }

    public decimal? LocalTaxDr { get; set; }

    public decimal? LocalTaxCr { get; set; }

    public decimal? TaxCurrencyTaxDr { get; set; }

    public decimal? TaxCurrencyTaxCr { get; set; }

    public decimal? TotalDr { get; set; }

    public decimal? TotalCr { get; set; }

    public string SupplyPurchase { get; set; } = null!;

    public string? TaxRefNo { get; set; }

    public string? TaxBrno { get; set; }

    public string? TaxRegisterNo { get; set; }

    public DateTime? TaxBillDate { get; set; }

    public string? TaxBname { get; set; }

    public string? TariffCode { get; set; }

    public decimal? DocTaxRate { get; set; }

    public string InclusiveTax { get; set; } = null!;

    public DateTime? DetailTaxDate { get; set; }

    public DateTime? PostingDate { get; set; }

    public string? AccNo { get; set; }

    public string? AccDescription { get; set; }

    public string? AccDesc2 { get; set; }

    public string? AccType { get; set; }

    public string? SpecialAccType { get; set; }

    public string? AccCurrencyCode { get; set; }

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

    public string? SalesAgent { get; set; }

    public string? SalesAgentDescription { get; set; }

    public string? SalesAgentDesc2 { get; set; }

    public byte[]? SalesAgentSignature { get; set; }
}
