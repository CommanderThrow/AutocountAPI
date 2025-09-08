using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2Debtor
{
    public string DebtorCode { get; set; } = null!;

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

    public string? DebtorTaxCode { get; set; }

    public string? DebtorTaxRegisterNo { get; set; }

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

    public string DebtorDisplayTerm { get; set; } = null!;

    public string? DebtorContactInfo { get; set; }

    public decimal? DebtorCreditLimit { get; set; }

    public decimal? DebtorOverdueLimit { get; set; }

    public string DebtorCurrencyCode { get; set; } = null!;

    public string? DebtorPostCode { get; set; }

    public string? DebtorDeliverPostCode { get; set; }

    public DateTime DebtorLastModified { get; set; }

    public string DebtorLastModifiedUserId { get; set; } = null!;

    public DateTime DebtorCreatedTimestamp { get; set; }

    public string DebtorCreatedUserId { get; set; } = null!;

    public string? AreaCode { get; set; }

    public string? DebtorType { get; set; }

    public string? SalesAgent { get; set; }

    public string? DebtorUdfJantina { get; set; }

    public string? DebtorUdfBangsa1 { get; set; }

    public string? DebtorUdfBangsa2 { get; set; }

    public string? DebtorUdfKerakyatan { get; set; }

    public DateTime? DebtorUdfTarikhLahir { get; set; }
}
