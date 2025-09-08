using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultBo
{
    public string Guid { get; set; } = null!;

    public string? DeviceId { get; set; }

    public string? LotNo { get; set; }

    public string? DocType { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public decimal? Rate { get; set; }

    public string? ActualBin { get; set; }

    public decimal? ActualQty { get; set; }

    public DateTime? CommittedDateTime { get; set; }

    public string? CommittedBy { get; set; }

    public bool? Posted { get; set; }

    public int? PostCount { get; set; }

    public string? SuggestDtlGuid { get; set; }

    public string? DocNo { get; set; }
}
