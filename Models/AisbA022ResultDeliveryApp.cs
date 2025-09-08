using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultDeliveryApp
{
    public string Guid { get; set; } = null!;

    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public string? DeviceId { get; set; }

    public string DocType { get; set; } = null!;

    public DateTime? LastModifiedDate { get; set; }

    public string? LastModifiedUserId { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CancelledUserId { get; set; }

    public DateTime? CancelledDate { get; set; }

    public bool? Cancelled { get; set; }

    public string? CommittedBy { get; set; }

    public DateTime? CommitedDateTime { get; set; }
}
