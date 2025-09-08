using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultTx
{
    public string Guid { get; set; } = null!;

    public string? DeviceId { get; set; }

    public string? DocType { get; set; }

    public string? DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? CommitedDateTime { get; set; }

    public string? CommittedBy { get; set; }

    public string? RefDocNo { get; set; }

    public string? FromLocation { get; set; }

    public string? ToLocation { get; set; }

    public string? AuthorisedBy { get; set; }

    public string? Ref { get; set; }

    public string? Reason { get; set; }

    public string? Description { get; set; }

    public bool? Posted { get; set; }

    public int? PostCount { get; set; }

    public bool? Cancelled { get; set; }

    public string? CancelledUserId { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? LastModifiedUserId { get; set; }
}
