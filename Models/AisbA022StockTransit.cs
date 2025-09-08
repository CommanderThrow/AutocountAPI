using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022StockTransit
{
    public string StockRequestId { get; set; } = null!;

    public long DocKey { get; set; }

    public string? DocType { get; set; }

    public DateTime DocDate { get; set; }

    public string DocNo { get; set; } = null!;

    public string? Description { get; set; }

    public string? RefDocNo { get; set; }

    public string? Reason { get; set; }

    public string? Ref { get; set; }

    public string? AuthorisedBy { get; set; }

    public string LocationFrom { get; set; } = null!;

    public string? LocationTo { get; set; }

    public bool? UseTransit { get; set; }

    public string? LocationTransit { get; set; }

    public string? TransitDocumentNo { get; set; }

    public string? TransferredDocumentNo { get; set; }

    public string? AdjustmentDocumentNo { get; set; }

    public string? AdjustmentReason { get; set; }

    public decimal? Outstanding { get; set; }

    public string? StockStatus { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public long? PrintCount { get; set; }

    public bool Cancelled { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string CreatedUser { get; set; } = null!;

    public DateTime LastModifiedDateTime { get; set; }

    public string LastModifiedUser { get; set; } = null!;

    public string? DeviceId { get; set; }

    public bool Posted { get; set; }

    public long? DocKey2 { get; set; }

    public string? CommittedBy { get; set; }

    public DateTime? CommittedDateTime { get; set; }

    public string? OutstandingStatus { get; set; }
}
