using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultC
{
    public string Guid { get; set; } = null!;

    public string? DocNo { get; set; }

    public string? DeviceId { get; set; }

    public string? DocType { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DebtorCode { get; set; }

    public string? Location { get; set; }

    public string? TransFromDoc { get; set; }

    public bool? Posted { get; set; }

    public int? PostCount { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? LastModifiedUserId { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CancelledUserId { get; set; }

    public DateTime? CancelledDate { get; set; }

    public bool? Cancelled { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? RoundingAdjustment { get; set; }

    public decimal? FinalTotal { get; set; }

    public string? CommittedBy { get; set; }

    public DateTime? CommitedDateTime { get; set; }

    public string? BranchCode { get; set; }

    public string? DebtorName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? ResultTaxEntityId { get; set; }

    public string? ResultTinNo { get; set; }
}
