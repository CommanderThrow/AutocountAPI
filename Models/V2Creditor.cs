using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2Creditor
{
    public string CreditorCode { get; set; } = null!;

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

    public string? CreditorTaxCode { get; set; }

    public string? CreditorTaxRegisterNo { get; set; }

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

    public string CreditorDisplayTerm { get; set; } = null!;

    public string? CreditorContactInfo { get; set; }

    public decimal? CreditorCreditLimit { get; set; }

    public decimal? CreditorOverdueLimit { get; set; }

    public string CreditorCurrencyCode { get; set; } = null!;

    public string? CreditorPostCode { get; set; }

    public string? CreditorDeliverPostCode { get; set; }

    public DateTime CreditorLastModified { get; set; }

    public string CreditorLastModifiedUserId { get; set; } = null!;

    public DateTime CreditorCreatedTimestamp { get; set; }

    public string CreditorCreatedUserId { get; set; } = null!;

    public string? AreaCode { get; set; }

    public string? CreditorType { get; set; }

    public string? PurchaseAgent { get; set; }
}
