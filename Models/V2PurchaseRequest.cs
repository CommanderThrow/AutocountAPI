using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2PurchaseRequest
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? Ref { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public string DocStatus { get; set; } = null!;

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public string? RequestedBy { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? ApprovalUserId { get; set; }

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public string CanSync { get; set; } = null!;

    public short PrintCount { get; set; }

    public string? PurchaseLocation { get; set; }

    public string? PqudfSuperAppId { get; set; }
}
