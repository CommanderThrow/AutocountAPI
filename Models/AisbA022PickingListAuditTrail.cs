using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022PickingListAuditTrail
{
    public string Guid { get; set; } = null!;

    public string? PickingListId { get; set; }

    public string? PickingListDtlId { get; set; }

    public string? UserId { get; set; }

    public DateTime? ModifiedTime { get; set; }

    public string? ActionType { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? OriginalQty { get; set; }

    public decimal? NewQty { get; set; }
}
