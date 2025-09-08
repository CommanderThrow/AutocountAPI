using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultRiin
{
    public string Guid { get; set; } = null!;

    public string? FromGuid { get; set; }

    public string? DeviceId { get; set; }

    public string? DocNo { get; set; }

    public string? ToBinCode { get; set; }

    public string? ToLotNo { get; set; }

    public decimal? ToActualQty { get; set; }

    public DateTime? CommittedDateTime { get; set; }

    public string? CommittedBy { get; set; }

    public bool? Posted { get; set; }

    public int? PostCount { get; set; }

    public DateTime? ScannedDateTime { get; set; }
}
