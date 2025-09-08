using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultBr
{
    public string Guid { get; set; } = null!;

    public int DtlKey { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public decimal? Qty { get; set; }

    public string? BatchNo { get; set; }

    public string? ActualBin { get; set; }

    public DateTime? ScannedDateTime { get; set; }

    public string? DeviceId { get; set; }

    public string? DtlGuid { get; set; }

    public string? FromBinCode { get; set; }

    public string? FromLotNo { get; set; }

    public decimal? FromActualQty { get; set; }

    public string? ToBinCode { get; set; }

    public string? ToLotNo { get; set; }

    public decimal? ToActualQty { get; set; }

    public string? CommittedBy { get; set; }

    public DateTime? CommittedDateTime { get; set; }

    public int? PostCount { get; set; }

    public int? Posted { get; set; }

    public string? DocNo { get; set; }
}
