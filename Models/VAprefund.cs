using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VAprefund
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public string? DocNo2 { get; set; }

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public decimal ToCreditorRate { get; set; }

    public decimal ToHomeRate { get; set; }

    public decimal? PaymentAmt { get; set; }

    public decimal? LocalPaymentAmt { get; set; }

    public decimal? KnockOffAmt { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyWord { get; set; }

    public string? CurrencyWord2 { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? FcgainAccount { get; set; }

    public string? FclossAccount { get; set; }

    public string? GainLossJournalType { get; set; }

    public string? ProjNo { get; set; }

    public string? ProjectDescription { get; set; }

    public string? ProjectDesc2 { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptDescription { get; set; }

    public string? DeptDesc2 { get; set; }

    public string? Note { get; set; }

    public string DocStatus { get; set; } = null!;

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public string? LastModifiedUserName { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? CreatedUserName { get; set; }

    public string? ExternalLink { get; set; }

    public string? SourceType { get; set; }

    public long? SourceKey { get; set; }

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
}
