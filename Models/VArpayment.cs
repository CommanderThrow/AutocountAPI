using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VArpayment
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public string? DocNo2 { get; set; }

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public decimal ToDebtorRate { get; set; }

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

    public string? DebtorCode { get; set; }

    public string? DebtorCompanyName { get; set; }

    public string? DebtorDesc2 { get; set; }

    public string? DebtorAddress1 { get; set; }

    public string? DebtorAddress2 { get; set; }

    public string? DebtorAddress3 { get; set; }

    public string? DebtorAddress4 { get; set; }

    public string? DebtorDeliverAddress1 { get; set; }

    public string? DebtorDeliverAddress2 { get; set; }

    public string? DebtorDeliverAddress3 { get; set; }

    public string? DebtorDeliverAddress4 { get; set; }

    public string? DebtorAttention { get; set; }

    public string? DebtorPhone1 { get; set; }

    public string? DebtorPhone2 { get; set; }

    public string? DebtorMobile { get; set; }

    public string? DebtorFax1 { get; set; }

    public string? DebtorFax2 { get; set; }

    public int? DebtorRoundingMethod { get; set; }

    public string? DebtorTaxCode { get; set; }

    public string? DebtorInclusiveTax { get; set; }

    public string? IsDebtorTaxRegistered { get; set; }

    public string? DebtorTaxRegisterNo { get; set; }

    public string? DebtorGstregisterNo { get; set; }

    public string? DebtorSstregisterNo { get; set; }

    public string? DebtorSelfBilledApprovalNo { get; set; }

    public string? DebtorExemptNo { get; set; }

    public DateTime? DebtorExemptExpiryDate { get; set; }

    public string? DebtorNote { get; set; }

    public string? DebtorPriceCategory { get; set; }

    public string? DebtorStatementType { get; set; }

    public string? DebtorAgingOn { get; set; }

    public string? DebtorRegisterNo { get; set; }

    public string? DebtorNatureOfBusiness { get; set; }

    public string? DebtorWebUrl { get; set; }

    public string? DebtorEmailAddress { get; set; }

    public string? DebtorDisplayTerm { get; set; }

    public string? DebtorContactInfo { get; set; }

    public decimal? DebtorCreditLimit { get; set; }

    public decimal? DebtorOverdueLimit { get; set; }

    public string? DebtorCurrencyCode { get; set; }

    public string? DebtorPostCode { get; set; }

    public string? DebtorDeliverPostCode { get; set; }

    public DateTime? DebtorLastModified { get; set; }

    public string? DebtorLastModifiedUserId { get; set; }

    public DateTime? DebtorCreatedTimestamp { get; set; }

    public string? DebtorCreatedUserId { get; set; }

    public DateTime? DebtorGststatusVerifiedDate { get; set; }

    public string? DebtorAreaCode { get; set; }

    public string? DebtorAreaDescription { get; set; }

    public string? DebtorAreaDesc2 { get; set; }

    public string? DebtorType { get; set; }

    public string? DebtorTypeDescription { get; set; }

    public string? DebtorTypeDesc2 { get; set; }

    public string? DebtorSalesAgent { get; set; }

    public string? DebtorSalesAgentDescription { get; set; }

    public string? DebtorSalesAgentDesc2 { get; set; }

    public byte[]? DebtorSalesAgentSignature { get; set; }

    public string? DebtorParentAccNo { get; set; }

    public string? DebtorUdfJantina { get; set; }

    public string? DebtorUdfBangsa1 { get; set; }

    public string? DebtorUdfBangsa2 { get; set; }

    public string? DebtorUdfKerakyatan { get; set; }

    public DateTime? DebtorUdfTarikhLahir { get; set; }

    public decimal? LocalUnappliedAmount { get; set; }

    public decimal? RefundAmt { get; set; }
}
