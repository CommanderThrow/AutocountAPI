using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022PickingListStatusTracking
{
    public string TrackingId { get; set; } = null!;

    public DateTime? TrackingTime { get; set; }

    public string? ReferenceId { get; set; }

    public DateTime? ReferenceTime { get; set; }

    public string? ReferenceType { get; set; }

    public string? SodocNo { get; set; }

    public long? SodocKey { get; set; }

    public long? SoDtlKey { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public string? Description { get; set; }

    public decimal? Qty { get; set; }

    public string? Status { get; set; }
}
