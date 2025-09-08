using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Agrn
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? CreditorCode { get; set; }

    public string? CreditorName { get; set; }

    public string? Ref { get; set; }

    public string? SupplierDono { get; set; }

    public string? Description { get; set; }

    public string DisplayTerm { get; set; } = null!;

    public string? PurchaseAgent { get; set; }

    public string? InvAddr1 { get; set; }

    public string? InvAddr2 { get; set; }

    public string? InvAddr3 { get; set; }

    public string? InvAddr4 { get; set; }

    public string? Phone1 { get; set; }

    public string? Fax1 { get; set; }

    public string? Attention { get; set; }

    public string? BranchCode { get; set; }

    public decimal? Total { get; set; }

    public decimal? Footer1Param { get; set; }

    public decimal? Footer1Amt { get; set; }

    public decimal? Footer1LocalAmt { get; set; }

    public string? Footer1TaxType { get; set; }

    public decimal? Footer2Param { get; set; }

    public decimal? Footer2Amt { get; set; }

    public decimal? Footer2LocalAmt { get; set; }

    public string? Footer2TaxType { get; set; }

    public decimal? Footer3Param { get; set; }

    public decimal? Footer3Amt { get; set; }

    public decimal? Footer3LocalAmt { get; set; }

    public string? Footer3TaxType { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public decimal? NetTotal { get; set; }

    public decimal? LocalNetTotal { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? ForeignCharges { get; set; }

    public decimal? LocalCharges { get; set; }

    public string? LandedCostMethod { get; set; }

    public bool PostToStock { get; set; }

    public bool Transferable { get; set; }

    public string? ToDocType { get; set; }

    public long? ToDocKey { get; set; }

    public string? Note { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public short PrintCount { get; set; }

    public bool Cancelled { get; set; }

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public bool CanSync { get; set; }

    public int LastUpdate { get; set; }

    public long? ToDtlKey { get; set; }

    public string? FullTransferOption { get; set; }

    public string? ShipVia { get; set; }

    public string? ShipInfo { get; set; }

    public string? PurchaseLocation { get; set; }

    public decimal? Footer1Tax { get; set; }

    public decimal? Footer1LocalTax { get; set; }

    public decimal? Footer2Tax { get; set; }

    public decimal? Footer2LocalTax { get; set; }

    public decimal? Footer3Tax { get; set; }

    public decimal? Footer3LocalTax { get; set; }

    public decimal? ExTax { get; set; }

    public decimal? LocalExTax { get; set; }

    public decimal? AnalysisNetTotal { get; set; }

    public decimal? LocalAnalysisNetTotal { get; set; }

    public Guid Guid { get; set; }

    public decimal ToTaxCurrencyRate { get; set; }

    public bool? CalcDiscountOnUnitPrice { get; set; }

    public decimal? TotalExTax { get; set; }

    public decimal? TaxableAmt { get; set; }

    public bool InclusiveTax { get; set; }

    public decimal? Footer1TaxRate { get; set; }

    public decimal? Footer2TaxRate { get; set; }

    public decimal? Footer3TaxRate { get; set; }

    public int RoundingMethod { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public string? ToDocNo { get; set; }
}
