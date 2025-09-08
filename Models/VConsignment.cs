﻿using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VConsignment
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

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

    public string? DeliverAddr1 { get; set; }

    public string? DeliverAddr2 { get; set; }

    public string? DeliverAddr3 { get; set; }

    public string? DeliverAddr4 { get; set; }

    public string? DeliverPhone1 { get; set; }

    public string? DeliverFax1 { get; set; }

    public string? DeliverContact { get; set; }

    public string? SalesExemptionNo { get; set; }

    public DateTime? SalesExemptionExpiryDate { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalExTax { get; set; }

    public string? ShipVia { get; set; }

    public string? ShipInfo { get; set; }

    public string? SalesLocation { get; set; }

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

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public string CanSync { get; set; } = null!;

    public short PrintCount { get; set; }

    public string? DebtorName { get; set; }

    public string InclusiveTax { get; set; } = null!;

    public string? MultiPrice { get; set; }

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

    public string? SalesAgent { get; set; }

    public string? SalesAgentDescription { get; set; }

    public string? SalesAgentDesc2 { get; set; }

    public byte[]? SalesAgentSignature { get; set; }

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
}
