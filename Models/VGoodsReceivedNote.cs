using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VGoodsReceivedNote
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? TaxRegisterNo { get; set; }

    public string? Ref { get; set; }

    public string? Description { get; set; }

    public long? ToDocKey { get; set; }

    public string? ToDocType { get; set; }

    public string DisplayTerm { get; set; } = null!;

    public string? InvAddr1 { get; set; }

    public string? InvAddr2 { get; set; }

    public string? InvAddr3 { get; set; }

    public string? InvAddr4 { get; set; }

    public string? Phone1 { get; set; }

    public string? Fax1 { get; set; }

    public string? Attention { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalExTax { get; set; }

    public string? SupplierDono { get; set; }

    public string? ShipVia { get; set; }

    public string? ShipInfo { get; set; }

    public decimal? Footer1Param { get; set; }

    public decimal? Footer1Amt { get; set; }

    public decimal? Footer1LocalAmt { get; set; }

    public string? Footer1TaxCode { get; set; }

    public decimal? Footer1TaxRate { get; set; }

    public decimal? Footer1Tax { get; set; }

    public decimal? Footer1LocalTax { get; set; }

    public decimal? Footer2Param { get; set; }

    public decimal? Footer2Amt { get; set; }

    public decimal? Footer2LocalAmt { get; set; }

    public string? Footer2TaxCode { get; set; }

    public decimal? Footer2TaxRate { get; set; }

    public decimal? Footer2Tax { get; set; }

    public decimal? Footer2LocalTax { get; set; }

    public decimal? Footer3Param { get; set; }

    public decimal? Footer3Amt { get; set; }

    public decimal? Footer3LocalAmt { get; set; }

    public string? Footer3TaxCode { get; set; }

    public decimal? Footer3TaxRate { get; set; }

    public decimal? Footer3Tax { get; set; }

    public decimal? Footer3LocalTax { get; set; }

    public string PostToStock { get; set; } = null!;

    public decimal? TotalWithTax { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyWord { get; set; }

    public string? CurrencyWord2 { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? FcgainAccount { get; set; }

    public string? FclossAccount { get; set; }

    public string? GainLossJournalType { get; set; }

    public decimal ToTaxCurrencyRate { get; set; }

    public decimal? TaxCurrencyExTax { get; set; }

    public decimal CurrencyRate { get; set; }

    public decimal? NetTotal { get; set; }

    public decimal? LocalNetTotal { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? ExTax { get; set; }

    public decimal? LocalExTax { get; set; }

    public string Transferable { get; set; } = null!;

    public string? Note { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public string DocStatus { get; set; } = null!;

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public string? LastModifiedUserName { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? CreatedUserName { get; set; }

    public string? PurchaseLocation { get; set; }

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public string CanSync { get; set; } = null!;

    public short PrintCount { get; set; }

    public decimal? LocalCharges { get; set; }

    public decimal? ForeignCharges { get; set; }

    public string? CreditorName { get; set; }

    public string InclusiveTax { get; set; } = null!;

    public string? CreditorCode { get; set; }

    public string? CreditorCompanyName { get; set; }

    public string? CreditorDesc2 { get; set; }

    public string? CreditorAddress1 { get; set; }

    public string? CreditorAddress2 { get; set; }

    public string? CreditorAddress3 { get; set; }

    public string? CreditorAddress4 { get; set; }

    public string? CreditorDeliverAddress1 { get; set; }

    public string? CreditorDeliverAddress2 { get; set; }

    public string? CreditorDeliverAddress3 { get; set; }

    public string? CreditorDeliverAddress4 { get; set; }

    public string? CreditorAttention { get; set; }

    public string? CreditorPhone1 { get; set; }

    public string? CreditorPhone2 { get; set; }

    public string? CreditorMobile { get; set; }

    public string? CreditorFax1 { get; set; }

    public string? CreditorFax2 { get; set; }

    public int? CreditorRoundingMethod { get; set; }

    public string? CreditorTaxCode { get; set; }

    public string? CreditorInclusiveTax { get; set; }

    public string? CreditorTaxRegisterNo { get; set; }

    public string? CreditorGstregisterNo { get; set; }

    public string? CreditorSstregisterNo { get; set; }

    public string? CreditorSelfBilledApprovalNo { get; set; }

    public string? CreditorExemptNo { get; set; }

    public DateTime? CreditorExemptExpiryDate { get; set; }

    public string? CreditorNote { get; set; }

    public string? CreditorPriceCategory { get; set; }

    public string? CreditorStatementType { get; set; }

    public string? CreditorAgingOn { get; set; }

    public string? CreditorRegisterNo { get; set; }

    public string? CreditorNatureOfBusiness { get; set; }

    public string? CreditorWebUrl { get; set; }

    public string? CreditorEmailAddress { get; set; }

    public string? CreditorDisplayTerm { get; set; }

    public string? CreditorContactInfo { get; set; }

    public decimal? CreditorCreditLimit { get; set; }

    public decimal? CreditorOverdueLimit { get; set; }

    public string? CreditorCurrencyCode { get; set; }

    public string? CreditorPostCode { get; set; }

    public string? CreditorDeliverPostCode { get; set; }

    public DateTime? CreditorLastModified { get; set; }

    public string? CreditorLastModifiedUserId { get; set; }

    public DateTime? CreditorCreatedTimestamp { get; set; }

    public string? CreditorCreatedUserId { get; set; }

    public DateTime? CreditorGststatusVerifiedDate { get; set; }

    public string? CreditorAreaCode { get; set; }

    public string? CreditorAreaDescription { get; set; }

    public string? CreditorAreaDesc2 { get; set; }

    public string? CreditorType { get; set; }

    public string? CreditorTypeDescription { get; set; }

    public string? CreditorTypeDesc2 { get; set; }

    public string? CreditorPurchaseAgent { get; set; }

    public string? CreditorPurchaseAgentDescription { get; set; }

    public string? CreditorPurchaseAgentDesc2 { get; set; }

    public byte[]? CreditorPurchaseAgentSignature { get; set; }

    public string? CreditorParentAccNo { get; set; }

    public string? PurchaseAgent { get; set; }

    public string? PurchaseAgentDescription { get; set; }

    public string? PurchaseAgentDesc2 { get; set; }

    public byte[]? PurchaseAgentSignature { get; set; }

    public string? BranchAccNo { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? BranchAddress1 { get; set; }

    public string? BranchAddress2 { get; set; }

    public string? BranchAddress3 { get; set; }

    public string? BranchAddress4 { get; set; }

    public string? BranchPostCode { get; set; }

    public string? BranchContact { get; set; }

    public string? BranchPhone1 { get; set; }

    public string? BranchPhone2 { get; set; }

    public string? BranchMobile { get; set; }

    public string? BranchFax1 { get; set; }

    public string? BranchFax2 { get; set; }

    public string? BranchSalesAgent { get; set; }

    public string? BranchPurchaseAgent { get; set; }

    public string? BranchAreaCode { get; set; }

    public string? BranchEmailAddress { get; set; }

    public string? BranchIsActive { get; set; }

    public string? GrudfSuperAppId { get; set; }
}
