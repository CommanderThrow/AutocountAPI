using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2ConsignmentReturn
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? Ref { get; set; }

    public string? Description { get; set; }

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

    public string? ShipVia { get; set; }

    public string? ShipInfo { get; set; }

    public string? SalesLocation { get; set; }

    public decimal? TotalWithTax { get; set; }

    public decimal ToTaxCurrencyRate { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? TaxCurrencyExTax { get; set; }

    public decimal CurrencyRate { get; set; }

    public decimal? NetTotal { get; set; }

    public decimal? LocalNetTotal { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

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

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public string CanSync { get; set; } = null!;

    public short PrintCount { get; set; }

    public string? DebtorName { get; set; }

    public string DebtorCode { get; set; } = null!;

    public string? BranchCode { get; set; }

    public string? SalesAgent { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? MultiPrice { get; set; }

    public decimal? TotalQty { get; set; }
}
