using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Manifest
{
    public string ManifestId { get; set; } = null!;

    public string? DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string? Description { get; set; }

    public string? LorryNo { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedTime { get; set; }

    public string? Status { get; set; }

    public string? Cancelled { get; set; }

    public string? Driver { get; set; }

    public string? DriverAssistant { get; set; }

    public string? PostedToDo { get; set; }

    public decimal? FinalTotalWeight { get; set; }

    public decimal? FinalTotalVolume { get; set; }

    public decimal? FinalTotalFocWeight { get; set; }

    public decimal? FinalTotalFocVolume { get; set; }

    public decimal? GrandTotalWeight { get; set; }

    public decimal? GrandTotalVolume { get; set; }

    public DateTime? LoadingStart { get; set; }

    public DateTime? LoadingEnd { get; set; }
}
