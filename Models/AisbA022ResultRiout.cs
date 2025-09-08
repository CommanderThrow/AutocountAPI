using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultRiout
{
    public string Guid { get; set; } = null!;

    public string? DeviceGuid { get; set; }

    public string? DeviceId { get; set; }

    public string? DocNo { get; set; }

    public string? FromBinCode { get; set; }

    public string? FromLotNo { get; set; }

    public decimal? FromActualQty { get; set; }

    public DateTime? CommittedDateTime { get; set; }

    public string? CommittedBy { get; set; }

    public bool? Posted { get; set; }

    public int? PostCount { get; set; }

    public DateTime? ScannedDateTime { get; set; }
}
