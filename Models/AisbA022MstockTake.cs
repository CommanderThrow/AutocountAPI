using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022MstockTake
{
    public string Mstid { get; set; } = null!;

    public string? DocNo { get; set; }

    public string? Description { get; set; }

    public string? RefDocNo { get; set; }

    public string? DeviceId { get; set; }

    public string? DocType { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DebtorCode { get; set; }

    public string? BranchCode { get; set; }

    public string? StockLocation { get; set; }

    public string? SalesAgent { get; set; }

    public string? PhotoId { get; set; }

    public decimal? LocationX { get; set; }

    public decimal? LocationY { get; set; }

    public bool? Posted { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastModifiedUserId { get; set; }

    public DateTime? LastModifiedDateTime { get; set; }

    public bool? Cancelled { get; set; }

    public string? CommittedUserId { get; set; }

    public DateTime? CommittedDateTime { get; set; }
}
